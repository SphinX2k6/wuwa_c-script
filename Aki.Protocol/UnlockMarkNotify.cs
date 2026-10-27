using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200148D RID: 5261
	[NetMessage(EMessageId.UnlockMarkNotify)]
	public sealed class UnlockMarkNotify : IMessage<UnlockMarkNotify>, IMessage, IEquatable<UnlockMarkNotify>, IDeepCloneable<UnlockMarkNotify>, IBufferMessage
	{
		// Token: 0x0601BD61 RID: 114017 RVA: 0x00406831 File Offset: 0x00404A31
		[NullableContext(1)]
		public static UnlockMarkNotify Create()
		{
			return new UnlockMarkNotify();
		}

		// Token: 0x17005DD6 RID: 24022
		// (get) Token: 0x0601BD62 RID: 114018 RVA: 0x00406838 File Offset: 0x00404A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DD7 RID: 24023
		// (get) Token: 0x0601BD63 RID: 114019 RVA: 0x0040683B File Offset: 0x00404A3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockMarkNotify.Descriptor;
			}
		}

		// Token: 0x0601BD64 RID: 114020 RVA: 0x00406842 File Offset: 0x00404A42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockMarkNotify()
		{
		}

		// Token: 0x0601BD65 RID: 114021 RVA: 0x0040684A File Offset: 0x00404A4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockMarkNotify(UnlockMarkNotify other) : this()
		{
			this.markId_ = other.markId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BD66 RID: 114022 RVA: 0x0040686F File Offset: 0x00404A6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockMarkNotify Clone()
		{
			return new UnlockMarkNotify(this);
		}

		// Token: 0x17005DD8 RID: 24024
		// (get) Token: 0x0601BD67 RID: 114023 RVA: 0x00406877 File Offset: 0x00404A77
		// (set) Token: 0x0601BD68 RID: 114024 RVA: 0x0040687F File Offset: 0x00404A7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MarkId
		{
			get
			{
				return this.markId_;
			}
			set
			{
				this.markId_ = value;
			}
		}

		// Token: 0x0601BD69 RID: 114025 RVA: 0x00406888 File Offset: 0x00404A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockMarkNotify);
		}

		// Token: 0x0601BD6A RID: 114026 RVA: 0x00406896 File Offset: 0x00404A96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockMarkNotify other)
		{
			return other != null && (other == this || (this.MarkId == other.MarkId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BD6B RID: 114027 RVA: 0x004068C4 File Offset: 0x00404AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MarkId != 0)
			{
				num ^= this.MarkId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BD6C RID: 114028 RVA: 0x00406903 File Offset: 0x00404B03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BD6D RID: 114029 RVA: 0x00406910 File Offset: 0x00404B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BD6E RID: 114030 RVA: 0x00406919 File Offset: 0x00404B19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MarkId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.MarkId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BD6F RID: 114031 RVA: 0x0040694C File Offset: 0x00404B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MarkId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MarkId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BD70 RID: 114032 RVA: 0x0040698A File Offset: 0x00404B8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlockMarkNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MarkId != 0)
			{
				this.MarkId = other.MarkId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BD71 RID: 114033 RVA: 0x004069BB File Offset: 0x00404BBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BD72 RID: 114034 RVA: 0x004069C4 File Offset: 0x00404BC4
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MarkId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A01D RID: 40989
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A01E RID: 40990
		public const int MarkIdFieldNumber = 11;

		// Token: 0x0400A01F RID: 40991
		private int markId_;
	}
}
