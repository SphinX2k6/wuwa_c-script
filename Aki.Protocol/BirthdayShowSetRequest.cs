using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200019F RID: 415
	[NetMessage(EMessageId.BirthdayShowSetRequest)]
	public sealed class BirthdayShowSetRequest : IMessage<BirthdayShowSetRequest>, IMessage, IEquatable<BirthdayShowSetRequest>, IDeepCloneable<BirthdayShowSetRequest>, IBufferMessage
	{
		// Token: 0x060030E5 RID: 12517 RVA: 0x0007C785 File Offset: 0x0007A985
		[NullableContext(1)]
		public static BirthdayShowSetRequest Create()
		{
			return new BirthdayShowSetRequest();
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x060030E6 RID: 12518 RVA: 0x0007C78C File Offset: 0x0007A98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x060030E7 RID: 12519 RVA: 0x0007C78F File Offset: 0x0007A98F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BirthdayShowSetRequest.Descriptor;
			}
		}

		// Token: 0x060030E8 RID: 12520 RVA: 0x0007C796 File Offset: 0x0007A996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthdayShowSetRequest()
		{
		}

		// Token: 0x060030E9 RID: 12521 RVA: 0x0007C79E File Offset: 0x0007A99E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthdayShowSetRequest(BirthdayShowSetRequest other) : this()
		{
			this.disPlay_ = other.disPlay_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060030EA RID: 12522 RVA: 0x0007C7C3 File Offset: 0x0007A9C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthdayShowSetRequest Clone()
		{
			return new BirthdayShowSetRequest(this);
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x060030EB RID: 12523 RVA: 0x0007C7CB File Offset: 0x0007A9CB
		// (set) Token: 0x060030EC RID: 12524 RVA: 0x0007C7D3 File Offset: 0x0007A9D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool DisPlay
		{
			get
			{
				return this.disPlay_;
			}
			set
			{
				this.disPlay_ = value;
			}
		}

		// Token: 0x060030ED RID: 12525 RVA: 0x0007C7DC File Offset: 0x0007A9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BirthdayShowSetRequest);
		}

		// Token: 0x060030EE RID: 12526 RVA: 0x0007C7EA File Offset: 0x0007A9EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BirthdayShowSetRequest other)
		{
			return other != null && (other == this || (this.DisPlay == other.DisPlay && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060030EF RID: 12527 RVA: 0x0007C818 File Offset: 0x0007AA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DisPlay)
			{
				num ^= this.DisPlay.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060030F0 RID: 12528 RVA: 0x0007C857 File Offset: 0x0007AA57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060030F1 RID: 12529 RVA: 0x0007C864 File Offset: 0x0007AA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060030F2 RID: 12530 RVA: 0x0007C86D File Offset: 0x0007AA6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DisPlay)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.DisPlay);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060030F3 RID: 12531 RVA: 0x0007C8A0 File Offset: 0x0007AAA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DisPlay)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060030F4 RID: 12532 RVA: 0x0007C8D2 File Offset: 0x0007AAD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BirthdayShowSetRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DisPlay)
			{
				this.DisPlay = other.DisPlay;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060030F5 RID: 12533 RVA: 0x0007C903 File Offset: 0x0007AB03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060030F6 RID: 12534 RVA: 0x0007C90C File Offset: 0x0007AB0C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.DisPlay = input.ReadBool();
				}
			}
		}

		// Token: 0x0400290C RID: 10508
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400290D RID: 10509
		public const int DisPlayFieldNumber = 9;

		// Token: 0x0400290E RID: 10510
		private bool disPlay_;
	}
}
