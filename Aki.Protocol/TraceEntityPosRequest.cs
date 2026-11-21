using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001443 RID: 5187
	[NetMessage(EMessageId.TraceEntityPosRequest)]
	public sealed class TraceEntityPosRequest : IMessage<TraceEntityPosRequest>, IMessage, IEquatable<TraceEntityPosRequest>, IDeepCloneable<TraceEntityPosRequest>, IBufferMessage
	{
		// Token: 0x0601B8F0 RID: 112880 RVA: 0x004015E0 File Offset: 0x003FF7E0
		[NullableContext(1)]
		public static TraceEntityPosRequest Create()
		{
			return new TraceEntityPosRequest();
		}

		// Token: 0x17005D4C RID: 23884
		// (get) Token: 0x0601B8F1 RID: 112881 RVA: 0x004015E7 File Offset: 0x003FF7E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D4D RID: 23885
		// (get) Token: 0x0601B8F2 RID: 112882 RVA: 0x004015EA File Offset: 0x003FF7EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TraceEntityPosRequest.Descriptor;
			}
		}

		// Token: 0x0601B8F3 RID: 112883 RVA: 0x004015F1 File Offset: 0x003FF7F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceEntityPosRequest()
		{
		}

		// Token: 0x0601B8F4 RID: 112884 RVA: 0x004015F9 File Offset: 0x003FF7F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceEntityPosRequest(TraceEntityPosRequest other) : this()
		{
			this.configId_ = other.configId_;
			this.dungeonId_ = other.dungeonId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B8F5 RID: 112885 RVA: 0x0040162A File Offset: 0x003FF82A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceEntityPosRequest Clone()
		{
			return new TraceEntityPosRequest(this);
		}

		// Token: 0x17005D4E RID: 23886
		// (get) Token: 0x0601B8F6 RID: 112886 RVA: 0x00401632 File Offset: 0x003FF832
		// (set) Token: 0x0601B8F7 RID: 112887 RVA: 0x0040163A File Offset: 0x003FF83A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17005D4F RID: 23887
		// (get) Token: 0x0601B8F8 RID: 112888 RVA: 0x00401643 File Offset: 0x003FF843
		// (set) Token: 0x0601B8F9 RID: 112889 RVA: 0x0040164B File Offset: 0x003FF84B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DungeonId
		{
			get
			{
				return this.dungeonId_;
			}
			set
			{
				this.dungeonId_ = value;
			}
		}

		// Token: 0x0601B8FA RID: 112890 RVA: 0x00401654 File Offset: 0x003FF854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TraceEntityPosRequest);
		}

		// Token: 0x0601B8FB RID: 112891 RVA: 0x00401662 File Offset: 0x003FF862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TraceEntityPosRequest other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.DungeonId == other.DungeonId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B8FC RID: 112892 RVA: 0x004016A0 File Offset: 0x003FF8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.DungeonId != 0)
			{
				num ^= this.DungeonId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B8FD RID: 112893 RVA: 0x004016F8 File Offset: 0x003FF8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B8FE RID: 112894 RVA: 0x00401705 File Offset: 0x003FF905
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B8FF RID: 112895 RVA: 0x00401710 File Offset: 0x003FF910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DungeonId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.DungeonId);
			}
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B900 RID: 112896 RVA: 0x0040176C File Offset: 0x003FF96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.DungeonId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DungeonId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B901 RID: 112897 RVA: 0x004017C4 File Offset: 0x003FF9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TraceEntityPosRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.DungeonId != 0)
			{
				this.DungeonId = other.DungeonId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B902 RID: 112898 RVA: 0x00401814 File Offset: 0x003FFA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B903 RID: 112899 RVA: 0x00401820 File Offset: 0x003FFA20
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
				if (num != 24U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ConfigId = input.ReadInt32();
					}
				}
				else
				{
					this.DungeonId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A04A RID: 41034
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A04B RID: 41035
		public const int ConfigIdFieldNumber = 9;

		// Token: 0x0400A04C RID: 41036
		private int configId_;

		// Token: 0x0400A04D RID: 41037
		public const int DungeonIdFieldNumber = 3;

		// Token: 0x0400A04E RID: 41038
		private int dungeonId_;
	}
}
