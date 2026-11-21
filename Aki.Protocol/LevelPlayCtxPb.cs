using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008E4 RID: 2276
	public sealed class LevelPlayCtxPb : IMessage<LevelPlayCtxPb>, IMessage, IEquatable<LevelPlayCtxPb>, IDeepCloneable<LevelPlayCtxPb>, IBufferMessage
	{
		// Token: 0x0600C992 RID: 51602 RVA: 0x001DC74E File Offset: 0x001DA94E
		[NullableContext(1)]
		public static LevelPlayCtxPb Create()
		{
			return new LevelPlayCtxPb();
		}

		// Token: 0x170028AE RID: 10414
		// (get) Token: 0x0600C993 RID: 51603 RVA: 0x001DC755 File Offset: 0x001DA955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028AF RID: 10415
		// (get) Token: 0x0600C994 RID: 51604 RVA: 0x001DC758 File Offset: 0x001DA958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayCtxPb.Descriptor;
			}
		}

		// Token: 0x0600C995 RID: 51605 RVA: 0x001DC75F File Offset: 0x001DA95F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayCtxPb()
		{
		}

		// Token: 0x0600C996 RID: 51606 RVA: 0x001DC767 File Offset: 0x001DA967
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayCtxPb(LevelPlayCtxPb other) : this()
		{
			this.levelPlayId_ = other.levelPlayId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C997 RID: 51607 RVA: 0x001DC78C File Offset: 0x001DA98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayCtxPb Clone()
		{
			return new LevelPlayCtxPb(this);
		}

		// Token: 0x170028B0 RID: 10416
		// (get) Token: 0x0600C998 RID: 51608 RVA: 0x001DC794 File Offset: 0x001DA994
		// (set) Token: 0x0600C999 RID: 51609 RVA: 0x001DC79C File Offset: 0x001DA99C
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

		// Token: 0x0600C99A RID: 51610 RVA: 0x001DC7A5 File Offset: 0x001DA9A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayCtxPb);
		}

		// Token: 0x0600C99B RID: 51611 RVA: 0x001DC7B3 File Offset: 0x001DA9B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayCtxPb other)
		{
			return other != null && (other == this || (this.LevelPlayId == other.LevelPlayId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C99C RID: 51612 RVA: 0x001DC7E4 File Offset: 0x001DA9E4
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

		// Token: 0x0600C99D RID: 51613 RVA: 0x001DC823 File Offset: 0x001DAA23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C99E RID: 51614 RVA: 0x001DC830 File Offset: 0x001DAA30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C99F RID: 51615 RVA: 0x001DC839 File Offset: 0x001DAA39
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

		// Token: 0x0600C9A0 RID: 51616 RVA: 0x001DC86C File Offset: 0x001DAA6C
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

		// Token: 0x0600C9A1 RID: 51617 RVA: 0x001DC8AA File Offset: 0x001DAAAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayCtxPb other)
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

		// Token: 0x0600C9A2 RID: 51618 RVA: 0x001DC8DB File Offset: 0x001DAADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C9A3 RID: 51619 RVA: 0x001DC8E4 File Offset: 0x001DAAE4
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

		// Token: 0x0400563E RID: 22078
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400563F RID: 22079
		public const int LevelPlayIdFieldNumber = 1;

		// Token: 0x04005640 RID: 22080
		private int levelPlayId_;
	}
}
