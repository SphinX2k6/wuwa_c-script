using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200115D RID: 4445
	public sealed class SceneItemAiInfoPb : IMessage<SceneItemAiInfoPb>, IMessage, IEquatable<SceneItemAiInfoPb>, IDeepCloneable<SceneItemAiInfoPb>, IBufferMessage
	{
		// Token: 0x06017B29 RID: 97065 RVA: 0x00371253 File Offset: 0x0036F453
		[NullableContext(1)]
		public static SceneItemAiInfoPb Create()
		{
			return new SceneItemAiInfoPb();
		}

		// Token: 0x17004F95 RID: 20373
		// (get) Token: 0x06017B2A RID: 97066 RVA: 0x0037125A File Offset: 0x0036F45A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F96 RID: 20374
		// (get) Token: 0x06017B2B RID: 97067 RVA: 0x0037125D File Offset: 0x0036F45D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemAiInfoPb.Descriptor;
			}
		}

		// Token: 0x06017B2C RID: 97068 RVA: 0x00371264 File Offset: 0x0036F464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAiInfoPb()
		{
		}

		// Token: 0x06017B2D RID: 97069 RVA: 0x0037126C File Offset: 0x0036F46C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAiInfoPb(SceneItemAiInfoPb other) : this()
		{
			if (other.InfosCase == SceneItemAiInfoPb.InfosOneofCase.SceneItemPatrolInfoPb)
			{
				this.SceneItemPatrolInfoPb = other.SceneItemPatrolInfoPb.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017B2E RID: 97070 RVA: 0x0037129F File Offset: 0x0036F49F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAiInfoPb Clone()
		{
			return new SceneItemAiInfoPb(this);
		}

		// Token: 0x17004F97 RID: 20375
		// (get) Token: 0x06017B2F RID: 97071 RVA: 0x003712A7 File Offset: 0x0036F4A7
		// (set) Token: 0x06017B30 RID: 97072 RVA: 0x003712BF File Offset: 0x0036F4BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemPatrolInfoPb SceneItemPatrolInfoPb
		{
			get
			{
				if (this.infosCase_ != SceneItemAiInfoPb.InfosOneofCase.SceneItemPatrolInfoPb)
				{
					return null;
				}
				return (SceneItemPatrolInfoPb)this.infos_;
			}
			set
			{
				this.infos_ = value;
				this.infosCase_ = ((value == null) ? SceneItemAiInfoPb.InfosOneofCase.None : SceneItemAiInfoPb.InfosOneofCase.SceneItemPatrolInfoPb);
			}
		}

		// Token: 0x17004F98 RID: 20376
		// (get) Token: 0x06017B31 RID: 97073 RVA: 0x003712D5 File Offset: 0x0036F4D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAiInfoPb.InfosOneofCase InfosCase
		{
			get
			{
				return this.infosCase_;
			}
		}

		// Token: 0x06017B32 RID: 97074 RVA: 0x003712DD File Offset: 0x0036F4DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearInfos()
		{
			this.infosCase_ = SceneItemAiInfoPb.InfosOneofCase.None;
			this.infos_ = null;
		}

		// Token: 0x06017B33 RID: 97075 RVA: 0x003712ED File Offset: 0x0036F4ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemAiInfoPb);
		}

		// Token: 0x06017B34 RID: 97076 RVA: 0x003712FC File Offset: 0x0036F4FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemAiInfoPb other)
		{
			return other != null && (other == this || (object.Equals(this.SceneItemPatrolInfoPb, other.SceneItemPatrolInfoPb) && this.InfosCase == other.InfosCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017B35 RID: 97077 RVA: 0x0037134C File Offset: 0x0036F54C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.infosCase_ == SceneItemAiInfoPb.InfosOneofCase.SceneItemPatrolInfoPb)
			{
				num ^= this.SceneItemPatrolInfoPb.GetHashCode();
			}
			num ^= (int)this.infosCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017B36 RID: 97078 RVA: 0x00371392 File Offset: 0x0036F592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017B37 RID: 97079 RVA: 0x0037139F File Offset: 0x0036F59F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017B38 RID: 97080 RVA: 0x003713A8 File Offset: 0x0036F5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.infosCase_ == SceneItemAiInfoPb.InfosOneofCase.SceneItemPatrolInfoPb)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.SceneItemPatrolInfoPb);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017B39 RID: 97081 RVA: 0x003713DC File Offset: 0x0036F5DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.infosCase_ == SceneItemAiInfoPb.InfosOneofCase.SceneItemPatrolInfoPb)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SceneItemPatrolInfoPb);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017B3A RID: 97082 RVA: 0x0037141C File Offset: 0x0036F61C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemAiInfoPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InfosCase == SceneItemAiInfoPb.InfosOneofCase.SceneItemPatrolInfoPb)
			{
				if (this.SceneItemPatrolInfoPb == null)
				{
					this.SceneItemPatrolInfoPb = new SceneItemPatrolInfoPb();
				}
				this.SceneItemPatrolInfoPb.MergeFrom(other.SceneItemPatrolInfoPb);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017B3B RID: 97083 RVA: 0x00371471 File Offset: 0x0036F671
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017B3C RID: 97084 RVA: 0x0037147C File Offset: 0x0036F67C
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					SceneItemPatrolInfoPb sceneItemPatrolInfoPb = new SceneItemPatrolInfoPb();
					if (this.infosCase_ == SceneItemAiInfoPb.InfosOneofCase.SceneItemPatrolInfoPb)
					{
						sceneItemPatrolInfoPb.MergeFrom(this.SceneItemPatrolInfoPb);
					}
					input.ReadMessage(sceneItemPatrolInfoPb);
					this.SceneItemPatrolInfoPb = sceneItemPatrolInfoPb;
				}
			}
		}

		// Token: 0x04008CBB RID: 36027
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008CBC RID: 36028
		public const int SceneItemPatrolInfoPbFieldNumber = 1;

		// Token: 0x04008CBD RID: 36029
		private object infos_;

		// Token: 0x04008CBE RID: 36030
		private SceneItemAiInfoPb.InfosOneofCase infosCase_;

		// Token: 0x02001975 RID: 6517
		public enum InfosOneofCase
		{
			// Token: 0x0400C9DB RID: 51675
			None,
			// Token: 0x0400C9DC RID: 51676
			SceneItemPatrolInfoPb
		}
	}
}
