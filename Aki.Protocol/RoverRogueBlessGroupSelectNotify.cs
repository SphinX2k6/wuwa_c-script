using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200112C RID: 4396
	[NetMessage(EMessageId.RoverRogueBlessGroupSelectNotify)]
	public sealed class RoverRogueBlessGroupSelectNotify : IMessage<RoverRogueBlessGroupSelectNotify>, IMessage, IEquatable<RoverRogueBlessGroupSelectNotify>, IDeepCloneable<RoverRogueBlessGroupSelectNotify>, IBufferMessage
	{
		// Token: 0x060177C8 RID: 96200 RVA: 0x0036AC82 File Offset: 0x00368E82
		[NullableContext(1)]
		public static RoverRogueBlessGroupSelectNotify Create()
		{
			return new RoverRogueBlessGroupSelectNotify();
		}

		// Token: 0x17004EEF RID: 20207
		// (get) Token: 0x060177C9 RID: 96201 RVA: 0x0036AC89 File Offset: 0x00368E89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EF0 RID: 20208
		// (get) Token: 0x060177CA RID: 96202 RVA: 0x0036AC8C File Offset: 0x00368E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueBlessGroupSelectNotify.Descriptor;
			}
		}

		// Token: 0x060177CB RID: 96203 RVA: 0x0036AC93 File Offset: 0x00368E93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueBlessGroupSelectNotify()
		{
		}

		// Token: 0x060177CC RID: 96204 RVA: 0x0036ACA6 File Offset: 0x00368EA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueBlessGroupSelectNotify(RoverRogueBlessGroupSelectNotify other) : this()
		{
			this.blessGroupData_ = other.blessGroupData_.Clone();
			this.isToken_ = other.isToken_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060177CD RID: 96205 RVA: 0x0036ACDC File Offset: 0x00368EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueBlessGroupSelectNotify Clone()
		{
			return new RoverRogueBlessGroupSelectNotify(this);
		}

		// Token: 0x17004EF1 RID: 20209
		// (get) Token: 0x060177CE RID: 96206 RVA: 0x0036ACE4 File Offset: 0x00368EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueBlessGroupData> BlessGroupData
		{
			get
			{
				return this.blessGroupData_;
			}
		}

		// Token: 0x17004EF2 RID: 20210
		// (get) Token: 0x060177CF RID: 96207 RVA: 0x0036ACEC File Offset: 0x00368EEC
		// (set) Token: 0x060177D0 RID: 96208 RVA: 0x0036ACF4 File Offset: 0x00368EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsToken
		{
			get
			{
				return this.isToken_;
			}
			set
			{
				this.isToken_ = value;
			}
		}

		// Token: 0x060177D1 RID: 96209 RVA: 0x0036ACFD File Offset: 0x00368EFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueBlessGroupSelectNotify);
		}

		// Token: 0x060177D2 RID: 96210 RVA: 0x0036AD0C File Offset: 0x00368F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueBlessGroupSelectNotify other)
		{
			return other != null && (other == this || (this.blessGroupData_.Equals(other.blessGroupData_) && this.IsToken == other.IsToken && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060177D3 RID: 96211 RVA: 0x0036AD5C File Offset: 0x00368F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.blessGroupData_.GetHashCode();
			if (this.IsToken)
			{
				num ^= this.IsToken.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060177D4 RID: 96212 RVA: 0x0036ADA9 File Offset: 0x00368FA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060177D5 RID: 96213 RVA: 0x0036ADB6 File Offset: 0x00368FB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060177D6 RID: 96214 RVA: 0x0036ADC0 File Offset: 0x00368FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsToken)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsToken);
			}
			this.blessGroupData_.WriteTo(ref output, RoverRogueBlessGroupSelectNotify._repeated_blessGroupData_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060177D7 RID: 96215 RVA: 0x0036AE10 File Offset: 0x00369010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.blessGroupData_.CalculateSize(RoverRogueBlessGroupSelectNotify._repeated_blessGroupData_codec);
			if (this.IsToken)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060177D8 RID: 96216 RVA: 0x0036AE58 File Offset: 0x00369058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueBlessGroupSelectNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.blessGroupData_.Add(other.blessGroupData_);
			if (other.IsToken)
			{
				this.IsToken = other.IsToken;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060177D9 RID: 96217 RVA: 0x0036AEA5 File Offset: 0x003690A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060177DA RID: 96218 RVA: 0x0036AEB0 File Offset: 0x003690B0
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
				if (num != 32U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.blessGroupData_.AddEntriesFrom(ref input, RoverRogueBlessGroupSelectNotify._repeated_blessGroupData_codec);
					}
				}
				else
				{
					this.IsToken = input.ReadBool();
				}
			}
		}

		// Token: 0x04008C34 RID: 35892
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008C35 RID: 35893
		public const int BlessGroupDataFieldNumber = 11;

		// Token: 0x04008C36 RID: 35894
		private static readonly FieldCodec<RoverRogueBlessGroupData> _repeated_blessGroupData_codec = FieldCodec.ForMessage<RoverRogueBlessGroupData>(90U, RoverRogueBlessGroupData.Parser);

		// Token: 0x04008C37 RID: 35895
		private readonly RepeatedField<RoverRogueBlessGroupData> blessGroupData_ = new RepeatedField<RoverRogueBlessGroupData>();

		// Token: 0x04008C38 RID: 35896
		public const int IsTokenFieldNumber = 4;

		// Token: 0x04008C39 RID: 35897
		private bool isToken_;
	}
}
