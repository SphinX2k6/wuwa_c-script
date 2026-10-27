using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200115C RID: 4444
	[NetMessage(EMessageId.SceneItemAiEnableNotify)]
	public sealed class SceneItemAiEnableNotify : IMessage<SceneItemAiEnableNotify>, IMessage, IEquatable<SceneItemAiEnableNotify>, IDeepCloneable<SceneItemAiEnableNotify>, IBufferMessage
	{
		// Token: 0x06017B15 RID: 97045 RVA: 0x00370F65 File Offset: 0x0036F165
		[NullableContext(1)]
		public static SceneItemAiEnableNotify Create()
		{
			return new SceneItemAiEnableNotify();
		}

		// Token: 0x17004F91 RID: 20369
		// (get) Token: 0x06017B16 RID: 97046 RVA: 0x00370F6C File Offset: 0x0036F16C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F92 RID: 20370
		// (get) Token: 0x06017B17 RID: 97047 RVA: 0x00370F6F File Offset: 0x0036F16F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemAiEnableNotify.Descriptor;
			}
		}

		// Token: 0x06017B18 RID: 97048 RVA: 0x00370F76 File Offset: 0x0036F176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAiEnableNotify()
		{
		}

		// Token: 0x06017B19 RID: 97049 RVA: 0x00370F80 File Offset: 0x0036F180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAiEnableNotify(SceneItemAiEnableNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.aiInfo_ = ((other.aiInfo_ != null) ? other.aiInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017B1A RID: 97050 RVA: 0x00370FCC File Offset: 0x0036F1CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAiEnableNotify Clone()
		{
			return new SceneItemAiEnableNotify(this);
		}

		// Token: 0x17004F93 RID: 20371
		// (get) Token: 0x06017B1B RID: 97051 RVA: 0x00370FD4 File Offset: 0x0036F1D4
		// (set) Token: 0x06017B1C RID: 97052 RVA: 0x00370FDC File Offset: 0x0036F1DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17004F94 RID: 20372
		// (get) Token: 0x06017B1D RID: 97053 RVA: 0x00370FE5 File Offset: 0x0036F1E5
		// (set) Token: 0x06017B1E RID: 97054 RVA: 0x00370FED File Offset: 0x0036F1ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAiInfoPb AiInfo
		{
			get
			{
				return this.aiInfo_;
			}
			set
			{
				this.aiInfo_ = value;
			}
		}

		// Token: 0x06017B1F RID: 97055 RVA: 0x00370FF6 File Offset: 0x0036F1F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemAiEnableNotify);
		}

		// Token: 0x06017B20 RID: 97056 RVA: 0x00371004 File Offset: 0x0036F204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemAiEnableNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.AiInfo, other.AiInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017B21 RID: 97057 RVA: 0x00371054 File Offset: 0x0036F254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.aiInfo_ != null)
			{
				num ^= this.AiInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017B22 RID: 97058 RVA: 0x003710A9 File Offset: 0x0036F2A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017B23 RID: 97059 RVA: 0x003710B6 File Offset: 0x0036F2B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017B24 RID: 97060 RVA: 0x003710C0 File Offset: 0x0036F2C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.EntityId);
			}
			if (this.aiInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.AiInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017B25 RID: 97061 RVA: 0x0037111C File Offset: 0x0036F31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.aiInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AiInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017B26 RID: 97062 RVA: 0x00371174 File Offset: 0x0036F374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemAiEnableNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.aiInfo_ != null)
			{
				if (this.aiInfo_ == null)
				{
					this.AiInfo = new SceneItemAiInfoPb();
				}
				this.AiInfo.MergeFrom(other.AiInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017B27 RID: 97063 RVA: 0x003711DC File Offset: 0x0036F3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017B28 RID: 97064 RVA: 0x003711E8 File Offset: 0x0036F3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 72U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.aiInfo_ == null)
						{
							this.AiInfo = new SceneItemAiInfoPb();
						}
						input.ReadMessage(this.AiInfo);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04008CB6 RID: 36022
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008CB7 RID: 36023
		public const int EntityIdFieldNumber = 9;

		// Token: 0x04008CB8 RID: 36024
		private long entityId_;

		// Token: 0x04008CB9 RID: 36025
		public const int AiInfoFieldNumber = 14;

		// Token: 0x04008CBA RID: 36026
		private SceneItemAiInfoPb aiInfo_;
	}
}
