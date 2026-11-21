using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001152 RID: 4434
	[NetMessage(EMessageId.RoverRogueRefreshGainResponse)]
	public sealed class RoverRogueRefreshGainResponse : IMessage<RoverRogueRefreshGainResponse>, IMessage, IEquatable<RoverRogueRefreshGainResponse>, IDeepCloneable<RoverRogueRefreshGainResponse>, IBufferMessage
	{
		// Token: 0x06017B03 RID: 97027 RVA: 0x00372731 File Offset: 0x00370931
		[NullableContext(1)]
		public static RoverRogueRefreshGainResponse Create()
		{
			return new RoverRogueRefreshGainResponse();
		}

		// Token: 0x17004FAE RID: 20398
		// (get) Token: 0x06017B04 RID: 97028 RVA: 0x00372738 File Offset: 0x00370938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004FAF RID: 20399
		// (get) Token: 0x06017B05 RID: 97029 RVA: 0x0037273B File Offset: 0x0037093B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueRefreshGainResponse.Descriptor;
			}
		}

		// Token: 0x06017B06 RID: 97030 RVA: 0x00372742 File Offset: 0x00370942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueRefreshGainResponse()
		{
		}

		// Token: 0x06017B07 RID: 97031 RVA: 0x0037274C File Offset: 0x0037094C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueRefreshGainResponse(RoverRogueRefreshGainResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.chooseData_ = ((other.chooseData_ != null) ? other.chooseData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017B08 RID: 97032 RVA: 0x00372798 File Offset: 0x00370998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueRefreshGainResponse Clone()
		{
			return new RoverRogueRefreshGainResponse(this);
		}

		// Token: 0x17004FB0 RID: 20400
		// (get) Token: 0x06017B09 RID: 97033 RVA: 0x003727A0 File Offset: 0x003709A0
		// (set) Token: 0x06017B0A RID: 97034 RVA: 0x003727A8 File Offset: 0x003709A8
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

		// Token: 0x17004FB1 RID: 20401
		// (get) Token: 0x06017B0B RID: 97035 RVA: 0x003727B1 File Offset: 0x003709B1
		// (set) Token: 0x06017B0C RID: 97036 RVA: 0x003727B9 File Offset: 0x003709B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueChooseData ChooseData
		{
			get
			{
				return this.chooseData_;
			}
			set
			{
				this.chooseData_ = value;
			}
		}

		// Token: 0x06017B0D RID: 97037 RVA: 0x003727C2 File Offset: 0x003709C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueRefreshGainResponse);
		}

		// Token: 0x06017B0E RID: 97038 RVA: 0x003727D0 File Offset: 0x003709D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueRefreshGainResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.ChooseData, other.ChooseData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017B0F RID: 97039 RVA: 0x00372820 File Offset: 0x00370A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.chooseData_ != null)
			{
				num ^= this.ChooseData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017B10 RID: 97040 RVA: 0x0037287B File Offset: 0x00370A7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017B11 RID: 97041 RVA: 0x00372888 File Offset: 0x00370A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017B12 RID: 97042 RVA: 0x00372894 File Offset: 0x00370A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.chooseData_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.ChooseData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017B13 RID: 97043 RVA: 0x003728F0 File Offset: 0x00370AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.chooseData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChooseData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017B14 RID: 97044 RVA: 0x00372948 File Offset: 0x00370B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueRefreshGainResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.chooseData_ != null)
			{
				if (this.chooseData_ == null)
				{
					this.ChooseData = new RoverRogueChooseData();
				}
				this.ChooseData.MergeFrom(other.ChooseData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017B15 RID: 97045 RVA: 0x003729B0 File Offset: 0x00370BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017B16 RID: 97046 RVA: 0x003729BC File Offset: 0x00370BBC
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
				if (num != 48U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.chooseData_ == null)
						{
							this.ChooseData = new RoverRogueChooseData();
						}
						input.ReadMessage(this.ChooseData);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008D50 RID: 36176
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D51 RID: 36177
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04008D52 RID: 36178
		private ErrorCode errorCode_;

		// Token: 0x04008D53 RID: 36179
		public const int ChooseDataFieldNumber = 15;

		// Token: 0x04008D54 RID: 36180
		private RoverRogueChooseData chooseData_;
	}
}
