using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000A5 RID: 165
	[NetMessage(EMessageId.AddForbidControlNotify)]
	public sealed class AddForbidControlNotify : IMessage<AddForbidControlNotify>, IMessage, IEquatable<AddForbidControlNotify>, IDeepCloneable<AddForbidControlNotify>, IBufferMessage
	{
		// Token: 0x06001CDA RID: 7386 RVA: 0x0004FEBD File Offset: 0x0004E0BD
		[NullableContext(1)]
		public static AddForbidControlNotify Create()
		{
			return new AddForbidControlNotify();
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06001CDB RID: 7387 RVA: 0x0004FEC4 File Offset: 0x0004E0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06001CDC RID: 7388 RVA: 0x0004FEC7 File Offset: 0x0004E0C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddForbidControlNotify.Descriptor;
			}
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x0004FECE File Offset: 0x0004E0CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddForbidControlNotify()
		{
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x0004FEE1 File Offset: 0x0004E0E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddForbidControlNotify(AddForbidControlNotify other) : this()
		{
			this.forbidList_ = other.forbidList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x0004FF0B File Offset: 0x0004E10B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddForbidControlNotify Clone()
		{
			return new AddForbidControlNotify(this);
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06001CE0 RID: 7392 RVA: 0x0004FF13 File Offset: 0x0004E113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ControlParam> ForbidList
		{
			get
			{
				return this.forbidList_;
			}
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x0004FF1B File Offset: 0x0004E11B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddForbidControlNotify);
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x0004FF29 File Offset: 0x0004E129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddForbidControlNotify other)
		{
			return other != null && (other == this || (this.forbidList_.Equals(other.forbidList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x0004FF5C File Offset: 0x0004E15C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.forbidList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x0004FF90 File Offset: 0x0004E190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x0004FF9D File Offset: 0x0004E19D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001CE6 RID: 7398 RVA: 0x0004FFA6 File Offset: 0x0004E1A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.forbidList_.WriteTo(ref output, AddForbidControlNotify._repeated_forbidList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x0004FFD0 File Offset: 0x0004E1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.forbidList_.CalculateSize(AddForbidControlNotify._repeated_forbidList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x00050009 File Offset: 0x0004E209
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddForbidControlNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.forbidList_.Add(other.forbidList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x00050037 File Offset: 0x0004E237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x00050040 File Offset: 0x0004E240
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.forbidList_.AddEntriesFrom(ref input, AddForbidControlNotify._repeated_forbidList_codec);
				}
			}
		}

		// Token: 0x04002348 RID: 9032
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002349 RID: 9033
		public const int ForbidListFieldNumber = 12;

		// Token: 0x0400234A RID: 9034
		private static readonly FieldCodec<ControlParam> _repeated_forbidList_codec = FieldCodec.ForMessage<ControlParam>(98U, ControlParam.Parser);

		// Token: 0x0400234B RID: 9035
		private readonly RepeatedField<ControlParam> forbidList_ = new RepeatedField<ControlParam>();
	}
}
