using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010F2 RID: 4338
	[NetMessage(EMessageId.RoverRogueBlessGroupSelectNotify)]
	public sealed class RoverRogueBlessGroupSelectNotify : IMessage<RoverRogueBlessGroupSelectNotify>, IMessage, IEquatable<RoverRogueBlessGroupSelectNotify>, IDeepCloneable<RoverRogueBlessGroupSelectNotify>, IBufferMessage
	{
		// Token: 0x06017227 RID: 94759 RVA: 0x0035B92A File Offset: 0x00359B2A
		[NullableContext(1)]
		public static RoverRogueBlessGroupSelectNotify Create()
		{
			return new RoverRogueBlessGroupSelectNotify();
		}

		// Token: 0x17004D83 RID: 19843
		// (get) Token: 0x06017228 RID: 94760 RVA: 0x0035B931 File Offset: 0x00359B31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D84 RID: 19844
		// (get) Token: 0x06017229 RID: 94761 RVA: 0x0035B934 File Offset: 0x00359B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueBlessGroupSelectNotify.Descriptor;
			}
		}

		// Token: 0x0601722A RID: 94762 RVA: 0x0035B93B File Offset: 0x00359B3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueBlessGroupSelectNotify()
		{
		}

		// Token: 0x0601722B RID: 94763 RVA: 0x0035B94E File Offset: 0x00359B4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueBlessGroupSelectNotify(RoverRogueBlessGroupSelectNotify other) : this()
		{
			this.blessGroupData_ = other.blessGroupData_.Clone();
			this.isToken_ = other.isToken_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601722C RID: 94764 RVA: 0x0035B984 File Offset: 0x00359B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueBlessGroupSelectNotify Clone()
		{
			return new RoverRogueBlessGroupSelectNotify(this);
		}

		// Token: 0x17004D85 RID: 19845
		// (get) Token: 0x0601722D RID: 94765 RVA: 0x0035B98C File Offset: 0x00359B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueBlessGroupData> BlessGroupData
		{
			get
			{
				return this.blessGroupData_;
			}
		}

		// Token: 0x17004D86 RID: 19846
		// (get) Token: 0x0601722E RID: 94766 RVA: 0x0035B994 File Offset: 0x00359B94
		// (set) Token: 0x0601722F RID: 94767 RVA: 0x0035B99C File Offset: 0x00359B9C
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

		// Token: 0x06017230 RID: 94768 RVA: 0x0035B9A5 File Offset: 0x00359BA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueBlessGroupSelectNotify);
		}

		// Token: 0x06017231 RID: 94769 RVA: 0x0035B9B4 File Offset: 0x00359BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueBlessGroupSelectNotify other)
		{
			return other != null && (other == this || (this.blessGroupData_.Equals(other.blessGroupData_) && this.IsToken == other.IsToken && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017232 RID: 94770 RVA: 0x0035BA04 File Offset: 0x00359C04
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

		// Token: 0x06017233 RID: 94771 RVA: 0x0035BA51 File Offset: 0x00359C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017234 RID: 94772 RVA: 0x0035BA5E File Offset: 0x00359C5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017235 RID: 94773 RVA: 0x0035BA68 File Offset: 0x00359C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.blessGroupData_.WriteTo(ref output, RoverRogueBlessGroupSelectNotify._repeated_blessGroupData_codec);
			if (this.IsToken)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsToken);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017236 RID: 94774 RVA: 0x0035BAB8 File Offset: 0x00359CB8
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

		// Token: 0x06017237 RID: 94775 RVA: 0x0035BB00 File Offset: 0x00359D00
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

		// Token: 0x06017238 RID: 94776 RVA: 0x0035BB4D File Offset: 0x00359D4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017239 RID: 94777 RVA: 0x0035BB58 File Offset: 0x00359D58
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
				if (num != 50U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsToken = input.ReadBool();
					}
				}
				else
				{
					this.blessGroupData_.AddEntriesFrom(ref input, RoverRogueBlessGroupSelectNotify._repeated_blessGroupData_codec);
				}
			}
		}

		// Token: 0x040089A1 RID: 35233
		private UnknownFieldSet _unknownFields;

		// Token: 0x040089A2 RID: 35234
		public const int BlessGroupDataFieldNumber = 6;

		// Token: 0x040089A3 RID: 35235
		private static readonly FieldCodec<RoverRogueBlessGroupData> _repeated_blessGroupData_codec = FieldCodec.ForMessage<RoverRogueBlessGroupData>(50U, RoverRogueBlessGroupData.Parser);

		// Token: 0x040089A4 RID: 35236
		private readonly RepeatedField<RoverRogueBlessGroupData> blessGroupData_ = new RepeatedField<RoverRogueBlessGroupData>();

		// Token: 0x040089A5 RID: 35237
		public const int IsTokenFieldNumber = 15;

		// Token: 0x040089A6 RID: 35238
		private bool isToken_;
	}
}
