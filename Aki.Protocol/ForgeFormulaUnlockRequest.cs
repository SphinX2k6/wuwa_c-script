using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200061D RID: 1565
	[NetMessage(EMessageId.ForgeFormulaUnlockRequest)]
	public sealed class ForgeFormulaUnlockRequest : IMessage<ForgeFormulaUnlockRequest>, IMessage, IEquatable<ForgeFormulaUnlockRequest>, IDeepCloneable<ForgeFormulaUnlockRequest>, IBufferMessage
	{
		// Token: 0x06009073 RID: 36979 RVA: 0x0015DB60 File Offset: 0x0015BD60
		[NullableContext(1)]
		public static ForgeFormulaUnlockRequest Create()
		{
			return new ForgeFormulaUnlockRequest();
		}

		// Token: 0x17001CB0 RID: 7344
		// (get) Token: 0x06009074 RID: 36980 RVA: 0x0015DB67 File Offset: 0x0015BD67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CB1 RID: 7345
		// (get) Token: 0x06009075 RID: 36981 RVA: 0x0015DB6A File Offset: 0x0015BD6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ForgeFormulaUnlockRequest.Descriptor;
			}
		}

		// Token: 0x06009076 RID: 36982 RVA: 0x0015DB71 File Offset: 0x0015BD71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeFormulaUnlockRequest()
		{
		}

		// Token: 0x06009077 RID: 36983 RVA: 0x0015DB79 File Offset: 0x0015BD79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeFormulaUnlockRequest(ForgeFormulaUnlockRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009078 RID: 36984 RVA: 0x0015DB9E File Offset: 0x0015BD9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeFormulaUnlockRequest Clone()
		{
			return new ForgeFormulaUnlockRequest(this);
		}

		// Token: 0x17001CB2 RID: 7346
		// (get) Token: 0x06009079 RID: 36985 RVA: 0x0015DBA6 File Offset: 0x0015BDA6
		// (set) Token: 0x0600907A RID: 36986 RVA: 0x0015DBAE File Offset: 0x0015BDAE
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

		// Token: 0x0600907B RID: 36987 RVA: 0x0015DBB7 File Offset: 0x0015BDB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ForgeFormulaUnlockRequest);
		}

		// Token: 0x0600907C RID: 36988 RVA: 0x0015DBC5 File Offset: 0x0015BDC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ForgeFormulaUnlockRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600907D RID: 36989 RVA: 0x0015DBF4 File Offset: 0x0015BDF4
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

		// Token: 0x0600907E RID: 36990 RVA: 0x0015DC33 File Offset: 0x0015BE33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600907F RID: 36991 RVA: 0x0015DC40 File Offset: 0x0015BE40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009080 RID: 36992 RVA: 0x0015DC49 File Offset: 0x0015BE49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009081 RID: 36993 RVA: 0x0015DC7C File Offset: 0x0015BE7C
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

		// Token: 0x06009082 RID: 36994 RVA: 0x0015DCBA File Offset: 0x0015BEBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ForgeFormulaUnlockRequest other)
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

		// Token: 0x06009083 RID: 36995 RVA: 0x0015DCEB File Offset: 0x0015BEEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009084 RID: 36996 RVA: 0x0015DCF4 File Offset: 0x0015BEF4
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040045F0 RID: 17904
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045F1 RID: 17905
		public const int IdFieldNumber = 7;

		// Token: 0x040045F2 RID: 17906
		private int id_;
	}
}
