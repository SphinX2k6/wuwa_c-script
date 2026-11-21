using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200111F RID: 4383
	[NetMessage(EMessageId.RollBlockResetGamePlayResponse)]
	public sealed class RollBlockResetGamePlayResponse : IMessage<RollBlockResetGamePlayResponse>, IMessage, IEquatable<RollBlockResetGamePlayResponse>, IDeepCloneable<RollBlockResetGamePlayResponse>, IBufferMessage
	{
		// Token: 0x060176B8 RID: 95928 RVA: 0x00368325 File Offset: 0x00366525
		[NullableContext(1)]
		public static RollBlockResetGamePlayResponse Create()
		{
			return new RollBlockResetGamePlayResponse();
		}

		// Token: 0x17004EB0 RID: 20144
		// (get) Token: 0x060176B9 RID: 95929 RVA: 0x0036832C File Offset: 0x0036652C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EB1 RID: 20145
		// (get) Token: 0x060176BA RID: 95930 RVA: 0x0036832F File Offset: 0x0036652F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockResetGamePlayResponse.Descriptor;
			}
		}

		// Token: 0x060176BB RID: 95931 RVA: 0x00368336 File Offset: 0x00366536
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockResetGamePlayResponse()
		{
		}

		// Token: 0x060176BC RID: 95932 RVA: 0x0036833E File Offset: 0x0036653E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockResetGamePlayResponse(RollBlockResetGamePlayResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060176BD RID: 95933 RVA: 0x00368363 File Offset: 0x00366563
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockResetGamePlayResponse Clone()
		{
			return new RollBlockResetGamePlayResponse(this);
		}

		// Token: 0x17004EB2 RID: 20146
		// (get) Token: 0x060176BE RID: 95934 RVA: 0x0036836B File Offset: 0x0036656B
		// (set) Token: 0x060176BF RID: 95935 RVA: 0x00368373 File Offset: 0x00366573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x060176C0 RID: 95936 RVA: 0x0036837C File Offset: 0x0036657C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockResetGamePlayResponse);
		}

		// Token: 0x060176C1 RID: 95937 RVA: 0x0036838A File Offset: 0x0036658A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockResetGamePlayResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060176C2 RID: 95938 RVA: 0x003683B8 File Offset: 0x003665B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060176C3 RID: 95939 RVA: 0x003683FD File Offset: 0x003665FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060176C4 RID: 95940 RVA: 0x0036840A File Offset: 0x0036660A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060176C5 RID: 95941 RVA: 0x00368413 File Offset: 0x00366613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060176C6 RID: 95942 RVA: 0x00368448 File Offset: 0x00366648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060176C7 RID: 95943 RVA: 0x00368486 File Offset: 0x00366686
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockResetGamePlayResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060176C8 RID: 95944 RVA: 0x003684B7 File Offset: 0x003666B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060176C9 RID: 95945 RVA: 0x003684C0 File Offset: 0x003666C0
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008BD0 RID: 35792
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BD1 RID: 35793
		public const int CodeFieldNumber = 4;

		// Token: 0x04008BD2 RID: 35794
		private ErrorCode code_;
	}
}
