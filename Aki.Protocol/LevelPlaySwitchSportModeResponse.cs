using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008FF RID: 2303
	[NetMessage(EMessageId.LevelPlaySwitchSportModeResponse)]
	public sealed class LevelPlaySwitchSportModeResponse : IMessage<LevelPlaySwitchSportModeResponse>, IMessage, IEquatable<LevelPlaySwitchSportModeResponse>, IDeepCloneable<LevelPlaySwitchSportModeResponse>, IBufferMessage
	{
		// Token: 0x0600CBB4 RID: 52148 RVA: 0x001E0D7B File Offset: 0x001DEF7B
		[NullableContext(1)]
		public static LevelPlaySwitchSportModeResponse Create()
		{
			return new LevelPlaySwitchSportModeResponse();
		}

		// Token: 0x1700291E RID: 10526
		// (get) Token: 0x0600CBB5 RID: 52149 RVA: 0x001E0D82 File Offset: 0x001DEF82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700291F RID: 10527
		// (get) Token: 0x0600CBB6 RID: 52150 RVA: 0x001E0D85 File Offset: 0x001DEF85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlaySwitchSportModeResponse.Descriptor;
			}
		}

		// Token: 0x0600CBB7 RID: 52151 RVA: 0x001E0D8C File Offset: 0x001DEF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlaySwitchSportModeResponse()
		{
		}

		// Token: 0x0600CBB8 RID: 52152 RVA: 0x001E0D94 File Offset: 0x001DEF94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlaySwitchSportModeResponse(LevelPlaySwitchSportModeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CBB9 RID: 52153 RVA: 0x001E0DB9 File Offset: 0x001DEFB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlaySwitchSportModeResponse Clone()
		{
			return new LevelPlaySwitchSportModeResponse(this);
		}

		// Token: 0x17002920 RID: 10528
		// (get) Token: 0x0600CBBA RID: 52154 RVA: 0x001E0DC1 File Offset: 0x001DEFC1
		// (set) Token: 0x0600CBBB RID: 52155 RVA: 0x001E0DC9 File Offset: 0x001DEFC9
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

		// Token: 0x0600CBBC RID: 52156 RVA: 0x001E0DD2 File Offset: 0x001DEFD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlaySwitchSportModeResponse);
		}

		// Token: 0x0600CBBD RID: 52157 RVA: 0x001E0DE0 File Offset: 0x001DEFE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlaySwitchSportModeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CBBE RID: 52158 RVA: 0x001E0E10 File Offset: 0x001DF010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CBBF RID: 52159 RVA: 0x001E0E55 File Offset: 0x001DF055
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CBC0 RID: 52160 RVA: 0x001E0E62 File Offset: 0x001DF062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CBC1 RID: 52161 RVA: 0x001E0E6B File Offset: 0x001DF06B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CBC2 RID: 52162 RVA: 0x001E0EA0 File Offset: 0x001DF0A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CBC3 RID: 52163 RVA: 0x001E0EDE File Offset: 0x001DF0DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlaySwitchSportModeResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CBC4 RID: 52164 RVA: 0x001E0F0F File Offset: 0x001DF10F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CBC5 RID: 52165 RVA: 0x001E0F18 File Offset: 0x001DF118
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040056D2 RID: 22226
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056D3 RID: 22227
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x040056D4 RID: 22228
		private ErrorCode errorCode_;
	}
}
