using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014F1 RID: 5361
	[NetMessage(EMessageId.UiGamePlayRequest)]
	public sealed class UiGamePlayRequest : IMessage<UiGamePlayRequest>, IMessage, IEquatable<UiGamePlayRequest>, IDeepCloneable<UiGamePlayRequest>, IBufferMessage
	{
		// Token: 0x0601C6C6 RID: 116422 RVA: 0x0041F71A File Offset: 0x0041D91A
		[NullableContext(1)]
		public static UiGamePlayRequest Create()
		{
			return new UiGamePlayRequest();
		}

		// Token: 0x17006031 RID: 24625
		// (get) Token: 0x0601C6C7 RID: 116423 RVA: 0x0041F721 File Offset: 0x0041D921
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006032 RID: 24626
		// (get) Token: 0x0601C6C8 RID: 116424 RVA: 0x0041F724 File Offset: 0x0041D924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UiGamePlayRequest.Descriptor;
			}
		}

		// Token: 0x0601C6C9 RID: 116425 RVA: 0x0041F72B File Offset: 0x0041D92B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UiGamePlayRequest()
		{
		}

		// Token: 0x0601C6CA RID: 116426 RVA: 0x0041F740 File Offset: 0x0041D940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UiGamePlayRequest(UiGamePlayRequest other) : this()
		{
			this.type_ = other.type_;
			this.gamePlayKey_ = other.gamePlayKey_;
			this.gamePlayData_ = ((other.gamePlayData_ != null) ? other.gamePlayData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C6CB RID: 116427 RVA: 0x0041F798 File Offset: 0x0041D998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UiGamePlayRequest Clone()
		{
			return new UiGamePlayRequest(this);
		}

		// Token: 0x17006033 RID: 24627
		// (get) Token: 0x0601C6CC RID: 116428 RVA: 0x0041F7A0 File Offset: 0x0041D9A0
		// (set) Token: 0x0601C6CD RID: 116429 RVA: 0x0041F7A8 File Offset: 0x0041D9A8
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

		// Token: 0x17006034 RID: 24628
		// (get) Token: 0x0601C6CE RID: 116430 RVA: 0x0041F7B1 File Offset: 0x0041D9B1
		// (set) Token: 0x0601C6CF RID: 116431 RVA: 0x0041F7B9 File Offset: 0x0041D9B9
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

		// Token: 0x17006035 RID: 24629
		// (get) Token: 0x0601C6D0 RID: 116432 RVA: 0x0041F7CC File Offset: 0x0041D9CC
		// (set) Token: 0x0601C6D1 RID: 116433 RVA: 0x0041F7D4 File Offset: 0x0041D9D4
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

		// Token: 0x0601C6D2 RID: 116434 RVA: 0x0041F7DD File Offset: 0x0041D9DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UiGamePlayRequest);
		}

		// Token: 0x0601C6D3 RID: 116435 RVA: 0x0041F7EC File Offset: 0x0041D9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UiGamePlayRequest other)
		{
			return other != null && (other == this || (this.Type == other.Type && !(this.GamePlayKey != other.GamePlayKey) && object.Equals(this.GamePlayData, other.GamePlayData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C6D4 RID: 116436 RVA: 0x0041F850 File Offset: 0x0041DA50
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

		// Token: 0x0601C6D5 RID: 116437 RVA: 0x0041F8C6 File Offset: 0x0041DAC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C6D6 RID: 116438 RVA: 0x0041F8D3 File Offset: 0x0041DAD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C6D7 RID: 116439 RVA: 0x0041F8DC File Offset: 0x0041DADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.gamePlayData_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.GamePlayData);
			}
			if (this.Type != UiGamePlayType.Cipher)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.Type);
			}
			if (this.GamePlayKey.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.GamePlayKey);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C6D8 RID: 116440 RVA: 0x0041F958 File Offset: 0x0041DB58
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

		// Token: 0x0601C6D9 RID: 116441 RVA: 0x0041F9CC File Offset: 0x0041DBCC
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

		// Token: 0x0601C6DA RID: 116442 RVA: 0x0041FA4D File Offset: 0x0041DC4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C6DB RID: 116443 RVA: 0x0041FA58 File Offset: 0x0041DC58
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
				if (num != 18U)
				{
					if (num != 96U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.GamePlayKey = input.ReadString();
						}
					}
					else
					{
						this.Type = (UiGamePlayType)input.ReadEnum();
					}
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
		}

		// Token: 0x0400A41C RID: 42012
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A41D RID: 42013
		public const int TypeFieldNumber = 12;

		// Token: 0x0400A41E RID: 42014
		private UiGamePlayType type_;

		// Token: 0x0400A41F RID: 42015
		public const int GamePlayKeyFieldNumber = 14;

		// Token: 0x0400A420 RID: 42016
		private string gamePlayKey_ = "";

		// Token: 0x0400A421 RID: 42017
		public const int GamePlayDataFieldNumber = 2;

		// Token: 0x0400A422 RID: 42018
		private UiGamePlayData gamePlayData_;
	}
}
