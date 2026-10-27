using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000178 RID: 376
	[NetMessage(EMessageId.BattlePassTaskTakeRequest)]
	public sealed class BattlePassTaskTakeRequest : IMessage<BattlePassTaskTakeRequest>, IMessage, IEquatable<BattlePassTaskTakeRequest>, IDeepCloneable<BattlePassTaskTakeRequest>, IBufferMessage
	{
		// Token: 0x06002DE9 RID: 11753 RVA: 0x00076870 File Offset: 0x00074A70
		[NullableContext(1)]
		public static BattlePassTaskTakeRequest Create()
		{
			return new BattlePassTaskTakeRequest();
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06002DEA RID: 11754 RVA: 0x00076877 File Offset: 0x00074A77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06002DEB RID: 11755 RVA: 0x0007687A File Offset: 0x00074A7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassTaskTakeRequest.Descriptor;
			}
		}

		// Token: 0x06002DEC RID: 11756 RVA: 0x00076881 File Offset: 0x00074A81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTaskTakeRequest()
		{
		}

		// Token: 0x06002DED RID: 11757 RVA: 0x00076894 File Offset: 0x00074A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTaskTakeRequest(BattlePassTaskTakeRequest other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002DEE RID: 11758 RVA: 0x000768BE File Offset: 0x00074ABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTaskTakeRequest Clone()
		{
			return new BattlePassTaskTakeRequest(this);
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06002DEF RID: 11759 RVA: 0x000768C6 File Offset: 0x00074AC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x06002DF0 RID: 11760 RVA: 0x000768CE File Offset: 0x00074ACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassTaskTakeRequest);
		}

		// Token: 0x06002DF1 RID: 11761 RVA: 0x000768DC File Offset: 0x00074ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassTaskTakeRequest other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002DF2 RID: 11762 RVA: 0x00076910 File Offset: 0x00074B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002DF3 RID: 11763 RVA: 0x00076944 File Offset: 0x00074B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002DF4 RID: 11764 RVA: 0x00076951 File Offset: 0x00074B51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002DF5 RID: 11765 RVA: 0x0007695A File Offset: 0x00074B5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, BattlePassTaskTakeRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002DF6 RID: 11766 RVA: 0x00076984 File Offset: 0x00074B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(BattlePassTaskTakeRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002DF7 RID: 11767 RVA: 0x000769BD File Offset: 0x00074BBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattlePassTaskTakeRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002DF8 RID: 11768 RVA: 0x000769EB File Offset: 0x00074BEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002DF9 RID: 11769 RVA: 0x000769F4 File Offset: 0x00074BF4
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
				if (num != 104U && num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, BattlePassTaskTakeRequest._repeated_ids_codec);
				}
			}
		}

		// Token: 0x04002853 RID: 10323
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002854 RID: 10324
		public const int IdsFieldNumber = 13;

		// Token: 0x04002855 RID: 10325
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04002856 RID: 10326
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
