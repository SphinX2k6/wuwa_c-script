using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CF4 RID: 3316
	[NetMessage(EMessageId.PhantomPutOnRequest)]
	public sealed class PhantomPutOnRequest : IMessage<PhantomPutOnRequest>, IMessage, IEquatable<PhantomPutOnRequest>, IDeepCloneable<PhantomPutOnRequest>, IBufferMessage
	{
		// Token: 0x06011EE6 RID: 73446 RVA: 0x0029F45B File Offset: 0x0029D65B
		[NullableContext(1)]
		public static PhantomPutOnRequest Create()
		{
			return new PhantomPutOnRequest();
		}

		// Token: 0x17003B6A RID: 15210
		// (get) Token: 0x06011EE7 RID: 73447 RVA: 0x0029F462 File Offset: 0x0029D662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B6B RID: 15211
		// (get) Token: 0x06011EE8 RID: 73448 RVA: 0x0029F465 File Offset: 0x0029D665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomPutOnRequest.Descriptor;
			}
		}

		// Token: 0x06011EE9 RID: 73449 RVA: 0x0029F46C File Offset: 0x0029D66C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomPutOnRequest()
		{
		}

		// Token: 0x06011EEA RID: 73450 RVA: 0x0029F474 File Offset: 0x0029D674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomPutOnRequest(PhantomPutOnRequest other) : this()
		{
			this.incId_ = other.incId_;
			this.roleId_ = other.roleId_;
			this.pos_ = other.pos_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011EEB RID: 73451 RVA: 0x0029F4B1 File Offset: 0x0029D6B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomPutOnRequest Clone()
		{
			return new PhantomPutOnRequest(this);
		}

		// Token: 0x17003B6C RID: 15212
		// (get) Token: 0x06011EEC RID: 73452 RVA: 0x0029F4B9 File Offset: 0x0029D6B9
		// (set) Token: 0x06011EED RID: 73453 RVA: 0x0029F4C1 File Offset: 0x0029D6C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x17003B6D RID: 15213
		// (get) Token: 0x06011EEE RID: 73454 RVA: 0x0029F4CA File Offset: 0x0029D6CA
		// (set) Token: 0x06011EEF RID: 73455 RVA: 0x0029F4D2 File Offset: 0x0029D6D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17003B6E RID: 15214
		// (get) Token: 0x06011EF0 RID: 73456 RVA: 0x0029F4DB File Offset: 0x0029D6DB
		// (set) Token: 0x06011EF1 RID: 73457 RVA: 0x0029F4E3 File Offset: 0x0029D6E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x06011EF2 RID: 73458 RVA: 0x0029F4EC File Offset: 0x0029D6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomPutOnRequest);
		}

		// Token: 0x06011EF3 RID: 73459 RVA: 0x0029F4FC File Offset: 0x0029D6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomPutOnRequest other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.RoleId == other.RoleId && this.Pos == other.Pos && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011EF4 RID: 73460 RVA: 0x0029F558 File Offset: 0x0029D758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.Pos != 0)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011EF5 RID: 73461 RVA: 0x0029F5C9 File Offset: 0x0029D7C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011EF6 RID: 73462 RVA: 0x0029F5D6 File Offset: 0x0029D7D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011EF7 RID: 73463 RVA: 0x0029F5E0 File Offset: 0x0029D7E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Pos != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Pos);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.RoleId);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011EF8 RID: 73464 RVA: 0x0029F658 File Offset: 0x0029D858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.Pos != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Pos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011EF9 RID: 73465 RVA: 0x0029F6C8 File Offset: 0x0029D8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomPutOnRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.Pos != 0)
			{
				this.Pos = other.Pos;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011EFA RID: 73466 RVA: 0x0029F72C File Offset: 0x0029D92C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011EFB RID: 73467 RVA: 0x0029F738 File Offset: 0x0029D938
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
				if (num != 40U)
				{
					if (num != 96U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IncId = input.ReadInt32();
						}
					}
					else
					{
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					this.Pos = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400706C RID: 28780
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400706D RID: 28781
		public const int IncIdFieldNumber = 14;

		// Token: 0x0400706E RID: 28782
		private int incId_;

		// Token: 0x0400706F RID: 28783
		public const int RoleIdFieldNumber = 12;

		// Token: 0x04007070 RID: 28784
		private int roleId_;

		// Token: 0x04007071 RID: 28785
		public const int PosFieldNumber = 5;

		// Token: 0x04007072 RID: 28786
		private int pos_;
	}
}
