using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200114C RID: 4428
	[NetMessage(EMessageId.SceneDateNotify)]
	public sealed class SceneDateNotify : IMessage<SceneDateNotify>, IMessage, IEquatable<SceneDateNotify>, IDeepCloneable<SceneDateNotify>, IBufferMessage
	{
		// Token: 0x060179B7 RID: 96695 RVA: 0x0036D6E4 File Offset: 0x0036B8E4
		[NullableContext(1)]
		public static SceneDateNotify Create()
		{
			return new SceneDateNotify();
		}

		// Token: 0x17004F3A RID: 20282
		// (get) Token: 0x060179B8 RID: 96696 RVA: 0x0036D6EB File Offset: 0x0036B8EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F3B RID: 20283
		// (get) Token: 0x060179B9 RID: 96697 RVA: 0x0036D6EE File Offset: 0x0036B8EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneDateNotify.Descriptor;
			}
		}

		// Token: 0x060179BA RID: 96698 RVA: 0x0036D6F5 File Offset: 0x0036B8F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneDateNotify()
		{
		}

		// Token: 0x060179BB RID: 96699 RVA: 0x0036D6FD File Offset: 0x0036B8FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneDateNotify(SceneDateNotify other) : this()
		{
			this.currDate_ = other.currDate_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060179BC RID: 96700 RVA: 0x0036D722 File Offset: 0x0036B922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneDateNotify Clone()
		{
			return new SceneDateNotify(this);
		}

		// Token: 0x17004F3C RID: 20284
		// (get) Token: 0x060179BD RID: 96701 RVA: 0x0036D72A File Offset: 0x0036B92A
		// (set) Token: 0x060179BE RID: 96702 RVA: 0x0036D732 File Offset: 0x0036B932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurrDate
		{
			get
			{
				return this.currDate_;
			}
			set
			{
				this.currDate_ = value;
			}
		}

		// Token: 0x060179BF RID: 96703 RVA: 0x0036D73B File Offset: 0x0036B93B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneDateNotify);
		}

		// Token: 0x060179C0 RID: 96704 RVA: 0x0036D749 File Offset: 0x0036B949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneDateNotify other)
		{
			return other != null && (other == this || (this.CurrDate == other.CurrDate && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060179C1 RID: 96705 RVA: 0x0036D778 File Offset: 0x0036B978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurrDate != 0U)
			{
				num ^= this.CurrDate.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060179C2 RID: 96706 RVA: 0x0036D7B7 File Offset: 0x0036B9B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060179C3 RID: 96707 RVA: 0x0036D7C4 File Offset: 0x0036B9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060179C4 RID: 96708 RVA: 0x0036D7CD File Offset: 0x0036B9CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurrDate != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.CurrDate);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060179C5 RID: 96709 RVA: 0x0036D800 File Offset: 0x0036BA00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurrDate != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurrDate);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060179C6 RID: 96710 RVA: 0x0036D83E File Offset: 0x0036BA3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneDateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurrDate != 0U)
			{
				this.CurrDate = other.CurrDate;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060179C7 RID: 96711 RVA: 0x0036D86F File Offset: 0x0036BA6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060179C8 RID: 96712 RVA: 0x0036D878 File Offset: 0x0036BA78
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CurrDate = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04008C29 RID: 35881
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008C2A RID: 35882
		public const int CurrDateFieldNumber = 3;

		// Token: 0x04008C2B RID: 35883
		private uint currDate_;
	}
}
