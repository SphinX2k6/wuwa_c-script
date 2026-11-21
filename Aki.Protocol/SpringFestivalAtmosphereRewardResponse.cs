using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012E4 RID: 4836
	[NetMessage(EMessageId.SpringFestivalAtmosphereRewardResponse)]
	public sealed class SpringFestivalAtmosphereRewardResponse : IMessage<SpringFestivalAtmosphereRewardResponse>, IMessage, IEquatable<SpringFestivalAtmosphereRewardResponse>, IDeepCloneable<SpringFestivalAtmosphereRewardResponse>, IBufferMessage
	{
		// Token: 0x06019CF6 RID: 105718 RVA: 0x003C4290 File Offset: 0x003C2490
		[NullableContext(1)]
		public static SpringFestivalAtmosphereRewardResponse Create()
		{
			return new SpringFestivalAtmosphereRewardResponse();
		}

		// Token: 0x17005770 RID: 22384
		// (get) Token: 0x06019CF7 RID: 105719 RVA: 0x003C4297 File Offset: 0x003C2497
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005771 RID: 22385
		// (get) Token: 0x06019CF8 RID: 105720 RVA: 0x003C429A File Offset: 0x003C249A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringFestivalAtmosphereRewardResponse.Descriptor;
			}
		}

		// Token: 0x06019CF9 RID: 105721 RVA: 0x003C42A1 File Offset: 0x003C24A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalAtmosphereRewardResponse()
		{
		}

		// Token: 0x06019CFA RID: 105722 RVA: 0x003C42A9 File Offset: 0x003C24A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalAtmosphereRewardResponse(SpringFestivalAtmosphereRewardResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019CFB RID: 105723 RVA: 0x003C42CE File Offset: 0x003C24CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalAtmosphereRewardResponse Clone()
		{
			return new SpringFestivalAtmosphereRewardResponse(this);
		}

		// Token: 0x17005772 RID: 22386
		// (get) Token: 0x06019CFC RID: 105724 RVA: 0x003C42D6 File Offset: 0x003C24D6
		// (set) Token: 0x06019CFD RID: 105725 RVA: 0x003C42DE File Offset: 0x003C24DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x06019CFE RID: 105726 RVA: 0x003C42E7 File Offset: 0x003C24E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringFestivalAtmosphereRewardResponse);
		}

		// Token: 0x06019CFF RID: 105727 RVA: 0x003C42F5 File Offset: 0x003C24F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringFestivalAtmosphereRewardResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019D00 RID: 105728 RVA: 0x003C4324 File Offset: 0x003C2524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019D01 RID: 105729 RVA: 0x003C4369 File Offset: 0x003C2569
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019D02 RID: 105730 RVA: 0x003C4376 File Offset: 0x003C2576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019D03 RID: 105731 RVA: 0x003C437F File Offset: 0x003C257F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019D04 RID: 105732 RVA: 0x003C43B4 File Offset: 0x003C25B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019D05 RID: 105733 RVA: 0x003C43F2 File Offset: 0x003C25F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringFestivalAtmosphereRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019D06 RID: 105734 RVA: 0x003C4423 File Offset: 0x003C2623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019D07 RID: 105735 RVA: 0x003C442C File Offset: 0x003C262C
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009866 RID: 39014
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009867 RID: 39015
		public const int ErrCodeFieldNumber = 13;

		// Token: 0x04009868 RID: 39016
		private ErrorCode errCode_;
	}
}
