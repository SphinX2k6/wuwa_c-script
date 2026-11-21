using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008E5 RID: 2277
	public sealed class LevelPlayDestroyActionCtxPb : IMessage<LevelPlayDestroyActionCtxPb>, IMessage, IEquatable<LevelPlayDestroyActionCtxPb>, IDeepCloneable<LevelPlayDestroyActionCtxPb>, IBufferMessage
	{
		// Token: 0x0600C9A4 RID: 51620 RVA: 0x001DC928 File Offset: 0x001DAB28
		[NullableContext(1)]
		public static LevelPlayDestroyActionCtxPb Create()
		{
			return new LevelPlayDestroyActionCtxPb();
		}

		// Token: 0x170028B1 RID: 10417
		// (get) Token: 0x0600C9A5 RID: 51621 RVA: 0x001DC92F File Offset: 0x001DAB2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028B2 RID: 10418
		// (get) Token: 0x0600C9A6 RID: 51622 RVA: 0x001DC932 File Offset: 0x001DAB32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayDestroyActionCtxPb.Descriptor;
			}
		}

		// Token: 0x0600C9A7 RID: 51623 RVA: 0x001DC939 File Offset: 0x001DAB39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayDestroyActionCtxPb()
		{
		}

		// Token: 0x0600C9A8 RID: 51624 RVA: 0x001DC941 File Offset: 0x001DAB41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayDestroyActionCtxPb(LevelPlayDestroyActionCtxPb other) : this()
		{
			this.levelPlayId_ = other.levelPlayId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C9A9 RID: 51625 RVA: 0x001DC966 File Offset: 0x001DAB66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayDestroyActionCtxPb Clone()
		{
			return new LevelPlayDestroyActionCtxPb(this);
		}

		// Token: 0x170028B3 RID: 10419
		// (get) Token: 0x0600C9AA RID: 51626 RVA: 0x001DC96E File Offset: 0x001DAB6E
		// (set) Token: 0x0600C9AB RID: 51627 RVA: 0x001DC976 File Offset: 0x001DAB76
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

		// Token: 0x0600C9AC RID: 51628 RVA: 0x001DC97F File Offset: 0x001DAB7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayDestroyActionCtxPb);
		}

		// Token: 0x0600C9AD RID: 51629 RVA: 0x001DC98D File Offset: 0x001DAB8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayDestroyActionCtxPb other)
		{
			return other != null && (other == this || (this.LevelPlayId == other.LevelPlayId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C9AE RID: 51630 RVA: 0x001DC9BC File Offset: 0x001DABBC
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

		// Token: 0x0600C9AF RID: 51631 RVA: 0x001DC9FB File Offset: 0x001DABFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C9B0 RID: 51632 RVA: 0x001DCA08 File Offset: 0x001DAC08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C9B1 RID: 51633 RVA: 0x001DCA11 File Offset: 0x001DAC11
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

		// Token: 0x0600C9B2 RID: 51634 RVA: 0x001DCA44 File Offset: 0x001DAC44
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

		// Token: 0x0600C9B3 RID: 51635 RVA: 0x001DCA82 File Offset: 0x001DAC82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayDestroyActionCtxPb other)
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

		// Token: 0x0600C9B4 RID: 51636 RVA: 0x001DCAB3 File Offset: 0x001DACB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C9B5 RID: 51637 RVA: 0x001DCABC File Offset: 0x001DACBC
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

		// Token: 0x04005641 RID: 22081
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005642 RID: 22082
		public const int LevelPlayIdFieldNumber = 1;

		// Token: 0x04005643 RID: 22083
		private int levelPlayId_;
	}
}
