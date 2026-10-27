using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006AF RID: 1711
	[NetMessage(EMessageId.GameplayTagResponse)]
	public sealed class GameplayTagResponse : IMessage<GameplayTagResponse>, IMessage, IEquatable<GameplayTagResponse>, IDeepCloneable<GameplayTagResponse>, IBufferMessage
	{
		// Token: 0x06009CF4 RID: 40180 RVA: 0x0017DE68 File Offset: 0x0017C068
		[NullableContext(1)]
		public static GameplayTagResponse Create()
		{
			return new GameplayTagResponse();
		}

		// Token: 0x17001F92 RID: 8082
		// (get) Token: 0x06009CF5 RID: 40181 RVA: 0x0017DE6F File Offset: 0x0017C06F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F93 RID: 8083
		// (get) Token: 0x06009CF6 RID: 40182 RVA: 0x0017DE72 File Offset: 0x0017C072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameplayTagResponse.Descriptor;
			}
		}

		// Token: 0x06009CF7 RID: 40183 RVA: 0x0017DE79 File Offset: 0x0017C079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagResponse()
		{
		}

		// Token: 0x06009CF8 RID: 40184 RVA: 0x0017DE81 File Offset: 0x0017C081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagResponse(GameplayTagResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009CF9 RID: 40185 RVA: 0x0017DEA6 File Offset: 0x0017C0A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagResponse Clone()
		{
			return new GameplayTagResponse(this);
		}

		// Token: 0x17001F94 RID: 8084
		// (get) Token: 0x06009CFA RID: 40186 RVA: 0x0017DEAE File Offset: 0x0017C0AE
		// (set) Token: 0x06009CFB RID: 40187 RVA: 0x0017DEB6 File Offset: 0x0017C0B6
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

		// Token: 0x06009CFC RID: 40188 RVA: 0x0017DEBF File Offset: 0x0017C0BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameplayTagResponse);
		}

		// Token: 0x06009CFD RID: 40189 RVA: 0x0017DECD File Offset: 0x0017C0CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GameplayTagResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009CFE RID: 40190 RVA: 0x0017DEFC File Offset: 0x0017C0FC
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

		// Token: 0x06009CFF RID: 40191 RVA: 0x0017DF41 File Offset: 0x0017C141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009D00 RID: 40192 RVA: 0x0017DF4E File Offset: 0x0017C14E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009D01 RID: 40193 RVA: 0x0017DF57 File Offset: 0x0017C157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009D02 RID: 40194 RVA: 0x0017DF88 File Offset: 0x0017C188
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

		// Token: 0x06009D03 RID: 40195 RVA: 0x0017DFC6 File Offset: 0x0017C1C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GameplayTagResponse other)
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

		// Token: 0x06009D04 RID: 40196 RVA: 0x0017DFF7 File Offset: 0x0017C1F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009D05 RID: 40197 RVA: 0x0017E000 File Offset: 0x0017C200
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040049E5 RID: 18917
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049E6 RID: 18918
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040049E7 RID: 18919
		private ErrorCode errorCode_;
	}
}
