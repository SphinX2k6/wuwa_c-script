using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200094A RID: 2378
	[NetMessage(EMessageId.LoginNotify)]
	public sealed class LoginNotify : IMessage<LoginNotify>, IMessage, IEquatable<LoginNotify>, IDeepCloneable<LoginNotify>, IBufferMessage
	{
		// Token: 0x0600D16A RID: 53610 RVA: 0x001ECE79 File Offset: 0x001EB079
		[NullableContext(1)]
		public static LoginNotify Create()
		{
			return new LoginNotify();
		}

		// Token: 0x17002A4F RID: 10831
		// (get) Token: 0x0600D16B RID: 53611 RVA: 0x001ECE80 File Offset: 0x001EB080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A50 RID: 10832
		// (get) Token: 0x0600D16C RID: 53612 RVA: 0x001ECE83 File Offset: 0x001EB083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LoginNotify.Descriptor;
			}
		}

		// Token: 0x0600D16D RID: 53613 RVA: 0x001ECE8A File Offset: 0x001EB08A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoginNotify()
		{
		}

		// Token: 0x0600D16E RID: 53614 RVA: 0x001ECE92 File Offset: 0x001EB092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoginNotify(LoginNotify other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D16F RID: 53615 RVA: 0x001ECEB7 File Offset: 0x001EB0B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoginNotify Clone()
		{
			return new LoginNotify(this);
		}

		// Token: 0x17002A51 RID: 10833
		// (get) Token: 0x0600D170 RID: 53616 RVA: 0x001ECEBF File Offset: 0x001EB0BF
		// (set) Token: 0x0600D171 RID: 53617 RVA: 0x001ECEC7 File Offset: 0x001EB0C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0600D172 RID: 53618 RVA: 0x001ECED0 File Offset: 0x001EB0D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LoginNotify);
		}

		// Token: 0x0600D173 RID: 53619 RVA: 0x001ECEDE File Offset: 0x001EB0DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LoginNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D174 RID: 53620 RVA: 0x001ECF0C File Offset: 0x001EB10C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D175 RID: 53621 RVA: 0x001ECF4B File Offset: 0x001EB14B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D176 RID: 53622 RVA: 0x001ECF58 File Offset: 0x001EB158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D177 RID: 53623 RVA: 0x001ECF61 File Offset: 0x001EB161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D178 RID: 53624 RVA: 0x001ECF94 File Offset: 0x001EB194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D179 RID: 53625 RVA: 0x001ECFD2 File Offset: 0x001EB1D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LoginNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D17A RID: 53626 RVA: 0x001ED003 File Offset: 0x001EB203
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D17B RID: 53627 RVA: 0x001ED00C File Offset: 0x001EB20C
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
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400580D RID: 22541
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400580E RID: 22542
		public const int IdFieldNumber = 1;

		// Token: 0x0400580F RID: 22543
		private int id_;
	}
}
