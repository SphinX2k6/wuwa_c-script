using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000067 RID: 103
	[NetMessage(EMessageId.AchievementReceiveResponse)]
	public sealed class AchievementReceiveResponse : IMessage<AchievementReceiveResponse>, IMessage, IEquatable<AchievementReceiveResponse>, IDeepCloneable<AchievementReceiveResponse>, IBufferMessage
	{
		// Token: 0x060016CC RID: 5836 RVA: 0x0003BBE4 File Offset: 0x00039DE4
		[NullableContext(1)]
		public static AchievementReceiveResponse Create()
		{
			return new AchievementReceiveResponse();
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060016CD RID: 5837 RVA: 0x0003BBEB File Offset: 0x00039DEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060016CE RID: 5838 RVA: 0x0003BBEE File Offset: 0x00039DEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementReceiveResponse.Descriptor;
			}
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x0003BBF5 File Offset: 0x00039DF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementReceiveResponse()
		{
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x0003BC14 File Offset: 0x00039E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementReceiveResponse(AchievementReceiveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorParams_ = other.errorParams_.Clone();
			this.itemMap_ = other.itemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x0003BC66 File Offset: 0x00039E66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementReceiveResponse Clone()
		{
			return new AchievementReceiveResponse(this);
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060016D2 RID: 5842 RVA: 0x0003BC6E File Offset: 0x00039E6E
		// (set) Token: 0x060016D3 RID: 5843 RVA: 0x0003BC76 File Offset: 0x00039E76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060016D4 RID: 5844 RVA: 0x0003BC7F File Offset: 0x00039E7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060016D5 RID: 5845 RVA: 0x0003BC87 File Offset: 0x00039E87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x0003BC8F File Offset: 0x00039E8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementReceiveResponse);
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x0003BCA0 File Offset: 0x00039EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AchievementReceiveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.errorParams_.Equals(other.errorParams_) && this.ItemMap.Equals(other.ItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x0003BD04 File Offset: 0x00039F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.errorParams_.GetHashCode();
			num ^= this.ItemMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x0003BD65 File Offset: 0x00039F65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x0003BD72 File Offset: 0x00039F72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x0003BD7C File Offset: 0x00039F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.itemMap_.WriteTo(ref output, AchievementReceiveResponse._map_itemMap_codec);
			this.errorParams_.WriteTo(ref output, AchievementReceiveResponse._repeated_errorParams_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x0003BDDC File Offset: 0x00039FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.errorParams_.CalculateSize(AchievementReceiveResponse._repeated_errorParams_codec);
			num += this.itemMap_.CalculateSize(AchievementReceiveResponse._map_itemMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x0003BE40 File Offset: 0x0003A040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AchievementReceiveResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.errorParams_.Add(other.errorParams_);
			this.itemMap_.MergeFrom(other.itemMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x0003BE9E File Offset: 0x0003A09E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x0003BEA8 File Offset: 0x0003A0A8
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
					if (num != 42U)
					{
						if (num != 58U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.errorParams_.AddEntriesFrom(ref input, AchievementReceiveResponse._repeated_errorParams_codec);
						}
					}
					else
					{
						this.itemMap_.AddEntriesFrom(ref input, AchievementReceiveResponse._map_itemMap_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002145 RID: 8517
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002146 RID: 8518
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04002147 RID: 8519
		private ErrorCode errorCode_;

		// Token: 0x04002148 RID: 8520
		public const int ErrorParamsFieldNumber = 7;

		// Token: 0x04002149 RID: 8521
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(58U);

		// Token: 0x0400214A RID: 8522
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();

		// Token: 0x0400214B RID: 8523
		public const int ItemMapFieldNumber = 5;

		// Token: 0x0400214C RID: 8524
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 42U);

		// Token: 0x0400214D RID: 8525
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();
	}
}
