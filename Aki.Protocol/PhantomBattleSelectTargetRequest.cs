using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CA3 RID: 3235
	[NetMessage(EMessageId.PhantomBattleSelectTargetRequest)]
	public sealed class PhantomBattleSelectTargetRequest : IMessage<PhantomBattleSelectTargetRequest>, IMessage, IEquatable<PhantomBattleSelectTargetRequest>, IDeepCloneable<PhantomBattleSelectTargetRequest>, IBufferMessage
	{
		// Token: 0x060118C4 RID: 71876 RVA: 0x002925E1 File Offset: 0x002907E1
		[NullableContext(1)]
		public static PhantomBattleSelectTargetRequest Create()
		{
			return new PhantomBattleSelectTargetRequest();
		}

		// Token: 0x17003A21 RID: 14881
		// (get) Token: 0x060118C5 RID: 71877 RVA: 0x002925E8 File Offset: 0x002907E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A22 RID: 14882
		// (get) Token: 0x060118C6 RID: 71878 RVA: 0x002925EB File Offset: 0x002907EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleSelectTargetRequest.Descriptor;
			}
		}

		// Token: 0x060118C7 RID: 71879 RVA: 0x002925F2 File Offset: 0x002907F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSelectTargetRequest()
		{
		}

		// Token: 0x060118C8 RID: 71880 RVA: 0x00292605 File Offset: 0x00290805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSelectTargetRequest(PhantomBattleSelectTargetRequest other) : this()
		{
			this.fighterUId_ = other.fighterUId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060118C9 RID: 71881 RVA: 0x0029262F File Offset: 0x0029082F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSelectTargetRequest Clone()
		{
			return new PhantomBattleSelectTargetRequest(this);
		}

		// Token: 0x17003A23 RID: 14883
		// (get) Token: 0x060118CA RID: 71882 RVA: 0x00292637 File Offset: 0x00290837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FighterUId
		{
			get
			{
				return this.fighterUId_;
			}
		}

		// Token: 0x060118CB RID: 71883 RVA: 0x0029263F File Offset: 0x0029083F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleSelectTargetRequest);
		}

		// Token: 0x060118CC RID: 71884 RVA: 0x0029264D File Offset: 0x0029084D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleSelectTargetRequest other)
		{
			return other != null && (other == this || (this.fighterUId_.Equals(other.fighterUId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060118CD RID: 71885 RVA: 0x00292680 File Offset: 0x00290880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.fighterUId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060118CE RID: 71886 RVA: 0x002926B4 File Offset: 0x002908B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060118CF RID: 71887 RVA: 0x002926C1 File Offset: 0x002908C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060118D0 RID: 71888 RVA: 0x002926CA File Offset: 0x002908CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.fighterUId_.WriteTo(ref output, PhantomBattleSelectTargetRequest._repeated_fighterUId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060118D1 RID: 71889 RVA: 0x002926F4 File Offset: 0x002908F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.fighterUId_.CalculateSize(PhantomBattleSelectTargetRequest._repeated_fighterUId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060118D2 RID: 71890 RVA: 0x0029272D File Offset: 0x0029092D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleSelectTargetRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.fighterUId_.Add(other.fighterUId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060118D3 RID: 71891 RVA: 0x0029275B File Offset: 0x0029095B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060118D4 RID: 71892 RVA: 0x00292764 File Offset: 0x00290964
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
				if (num != 112U && num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.fighterUId_.AddEntriesFrom(ref input, PhantomBattleSelectTargetRequest._repeated_fighterUId_codec);
				}
			}
		}

		// Token: 0x04006EFF RID: 28415
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F00 RID: 28416
		public const int FighterUIdFieldNumber = 14;

		// Token: 0x04006F01 RID: 28417
		private static readonly FieldCodec<int> _repeated_fighterUId_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04006F02 RID: 28418
		private readonly RepeatedField<int> fighterUId_ = new RepeatedField<int>();
	}
}
