using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008FF RID: 2303
	public sealed class LevelPlayOpenActionCtxPb : IMessage<LevelPlayOpenActionCtxPb>, IMessage, IEquatable<LevelPlayOpenActionCtxPb>, IDeepCloneable<LevelPlayOpenActionCtxPb>, IBufferMessage
	{
		// Token: 0x0600CB76 RID: 52086 RVA: 0x001E0365 File Offset: 0x001DE565
		[NullableContext(1)]
		public static LevelPlayOpenActionCtxPb Create()
		{
			return new LevelPlayOpenActionCtxPb();
		}

		// Token: 0x17002916 RID: 10518
		// (get) Token: 0x0600CB77 RID: 52087 RVA: 0x001E036C File Offset: 0x001DE56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002917 RID: 10519
		// (get) Token: 0x0600CB78 RID: 52088 RVA: 0x001E036F File Offset: 0x001DE56F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayOpenActionCtxPb.Descriptor;
			}
		}

		// Token: 0x0600CB79 RID: 52089 RVA: 0x001E0376 File Offset: 0x001DE576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayOpenActionCtxPb()
		{
		}

		// Token: 0x0600CB7A RID: 52090 RVA: 0x001E037E File Offset: 0x001DE57E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayOpenActionCtxPb(LevelPlayOpenActionCtxPb other) : this()
		{
			this.levelPlayId_ = other.levelPlayId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CB7B RID: 52091 RVA: 0x001E03A3 File Offset: 0x001DE5A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayOpenActionCtxPb Clone()
		{
			return new LevelPlayOpenActionCtxPb(this);
		}

		// Token: 0x17002918 RID: 10520
		// (get) Token: 0x0600CB7C RID: 52092 RVA: 0x001E03AB File Offset: 0x001DE5AB
		// (set) Token: 0x0600CB7D RID: 52093 RVA: 0x001E03B3 File Offset: 0x001DE5B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelPlayId
		{
			get
			{
				return this.levelPlayId_;
			}
			set
			{
				this.levelPlayId_ = value;
			}
		}

		// Token: 0x0600CB7E RID: 52094 RVA: 0x001E03BC File Offset: 0x001DE5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayOpenActionCtxPb);
		}

		// Token: 0x0600CB7F RID: 52095 RVA: 0x001E03CA File Offset: 0x001DE5CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayOpenActionCtxPb other)
		{
			return other != null && (other == this || (this.LevelPlayId == other.LevelPlayId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CB80 RID: 52096 RVA: 0x001E03F8 File Offset: 0x001DE5F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelPlayId != 0)
			{
				num ^= this.LevelPlayId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CB81 RID: 52097 RVA: 0x001E0437 File Offset: 0x001DE637
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CB82 RID: 52098 RVA: 0x001E0444 File Offset: 0x001DE644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CB83 RID: 52099 RVA: 0x001E044D File Offset: 0x001DE64D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelPlayId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelPlayId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CB84 RID: 52100 RVA: 0x001E0480 File Offset: 0x001DE680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelPlayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelPlayId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CB85 RID: 52101 RVA: 0x001E04BE File Offset: 0x001DE6BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayOpenActionCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelPlayId != 0)
			{
				this.LevelPlayId = other.LevelPlayId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CB86 RID: 52102 RVA: 0x001E04EF File Offset: 0x001DE6EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CB87 RID: 52103 RVA: 0x001E04F8 File Offset: 0x001DE6F8
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.LevelPlayId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400566D RID: 22125
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400566E RID: 22126
		public const int LevelPlayIdFieldNumber = 1;

		// Token: 0x0400566F RID: 22127
		private int levelPlayId_;
	}
}
