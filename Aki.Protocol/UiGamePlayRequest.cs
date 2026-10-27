using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200147E RID: 5246
	[NetMessage(EMessageId.UiGamePlayRequest)]
	public sealed class UiGamePlayRequest : IMessage<UiGamePlayRequest>, IMessage, IEquatable<UiGamePlayRequest>, IDeepCloneable<UiGamePlayRequest>, IBufferMessage
	{
		// Token: 0x0601BC3B RID: 113723 RVA: 0x00404456 File Offset: 0x00402656
		[NullableContext(1)]
		public static UiGamePlayRequest Create()
		{
			return new UiGamePlayRequest();
		}

		// Token: 0x17005D9C RID: 23964
		// (get) Token: 0x0601BC3C RID: 113724 RVA: 0x0040445D File Offset: 0x0040265D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D9D RID: 23965
		// (get) Token: 0x0601BC3D RID: 113725 RVA: 0x00404460 File Offset: 0x00402660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UiGamePlayRequest.Descriptor;
			}
		}

		// Token: 0x0601BC3E RID: 113726 RVA: 0x00404467 File Offset: 0x00402667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UiGamePlayRequest()
		{
		}

		// Token: 0x0601BC3F RID: 113727 RVA: 0x0040447C File Offset: 0x0040267C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UiGamePlayRequest(UiGamePlayRequest other) : this()
		{
			this.type_ = other.type_;
			this.gamePlayKey_ = other.gamePlayKey_;
			this.gamePlayData_ = ((other.gamePlayData_ != null) ? other.gamePlayData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BC40 RID: 113728 RVA: 0x004044D4 File Offset: 0x004026D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UiGamePlayRequest Clone()
		{
			return new UiGamePlayRequest(this);
		}

		// Token: 0x17005D9E RID: 23966
		// (get) Token: 0x0601BC41 RID: 113729 RVA: 0x004044DC File Offset: 0x004026DC
		// (set) Token: 0x0601BC42 RID: 113730 RVA: 0x004044E4 File Offset: 0x004026E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UiGamePlayType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17005D9F RID: 23967
		// (get) Token: 0x0601BC43 RID: 113731 RVA: 0x004044ED File Offset: 0x004026ED
		// (set) Token: 0x0601BC44 RID: 113732 RVA: 0x004044F5 File Offset: 0x004026F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string GamePlayKey
		{
			get
			{
				return this.gamePlayKey_;
			}
			set
			{
				this.gamePlayKey_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17005DA0 RID: 23968
		// (get) Token: 0x0601BC45 RID: 113733 RVA: 0x00404508 File Offset: 0x00402708
		// (set) Token: 0x0601BC46 RID: 113734 RVA: 0x00404510 File Offset: 0x00402710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UiGamePlayData GamePlayData
		{
			get
			{
				return this.gamePlayData_;
			}
			set
			{
				this.gamePlayData_ = value;
			}
		}

		// Token: 0x0601BC47 RID: 113735 RVA: 0x00404519 File Offset: 0x00402719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UiGamePlayRequest);
		}

		// Token: 0x0601BC48 RID: 113736 RVA: 0x00404528 File Offset: 0x00402728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UiGamePlayRequest other)
		{
			return other != null && (other == this || (this.Type == other.Type && !(this.GamePlayKey != other.GamePlayKey) && object.Equals(this.GamePlayData, other.GamePlayData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BC49 RID: 113737 RVA: 0x0040458C File Offset: 0x0040278C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != UiGamePlayType.Cipher)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.GamePlayKey.Length != 0)
			{
				num ^= this.GamePlayKey.GetHashCode();
			}
			if (this.gamePlayData_ != null)
			{
				num ^= this.GamePlayData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BC4A RID: 113738 RVA: 0x00404602 File Offset: 0x00402802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BC4B RID: 113739 RVA: 0x0040460F File Offset: 0x0040280F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BC4C RID: 113740 RVA: 0x00404618 File Offset: 0x00402818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GamePlayKey.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.GamePlayKey);
			}
			if (this.Type != UiGamePlayType.Cipher)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Type);
			}
			if (this.gamePlayData_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.GamePlayData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BC4D RID: 113741 RVA: 0x00404694 File Offset: 0x00402894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != UiGamePlayType.Cipher)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.GamePlayKey.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.GamePlayKey);
			}
			if (this.gamePlayData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GamePlayData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BC4E RID: 113742 RVA: 0x00404708 File Offset: 0x00402908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UiGamePlayRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != UiGamePlayType.Cipher)
			{
				this.Type = other.Type;
			}
			if (other.GamePlayKey.Length != 0)
			{
				this.GamePlayKey = other.GamePlayKey;
			}
			if (other.gamePlayData_ != null)
			{
				if (this.gamePlayData_ == null)
				{
					this.GamePlayData = new UiGamePlayData();
				}
				this.GamePlayData.MergeFrom(other.GamePlayData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BC4F RID: 113743 RVA: 0x00404789 File Offset: 0x00402989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BC50 RID: 113744 RVA: 0x00404794 File Offset: 0x00402994
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
				if (num != 26U)
				{
					if (num != 32U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.gamePlayData_ == null)
							{
								this.GamePlayData = new UiGamePlayData();
							}
							input.ReadMessage(this.GamePlayData);
						}
					}
					else
					{
						this.Type = (UiGamePlayType)input.ReadEnum();
					}
				}
				else
				{
					this.GamePlayKey = input.ReadString();
				}
			}
		}

		// Token: 0x04009FD5 RID: 40917
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009FD6 RID: 40918
		public const int TypeFieldNumber = 4;

		// Token: 0x04009FD7 RID: 40919
		private UiGamePlayType type_;

		// Token: 0x04009FD8 RID: 40920
		public const int GamePlayKeyFieldNumber = 3;

		// Token: 0x04009FD9 RID: 40921
		private string gamePlayKey_ = "";

		// Token: 0x04009FDA RID: 40922
		public const int GamePlayDataFieldNumber = 14;

		// Token: 0x04009FDB RID: 40923
		private UiGamePlayData gamePlayData_;
	}
}
