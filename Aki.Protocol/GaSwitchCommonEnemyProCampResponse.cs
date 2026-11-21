using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006A0 RID: 1696
	[NetMessage(EMessageId.GaSwitchCommonEnemyProCampResponse)]
	public sealed class GaSwitchCommonEnemyProCampResponse : IMessage<GaSwitchCommonEnemyProCampResponse>, IMessage, IEquatable<GaSwitchCommonEnemyProCampResponse>, IDeepCloneable<GaSwitchCommonEnemyProCampResponse>, IBufferMessage
	{
		// Token: 0x06009BF8 RID: 39928 RVA: 0x0017BD66 File Offset: 0x00179F66
		[NullableContext(1)]
		public static GaSwitchCommonEnemyProCampResponse Create()
		{
			return new GaSwitchCommonEnemyProCampResponse();
		}

		// Token: 0x17001F57 RID: 8023
		// (get) Token: 0x06009BF9 RID: 39929 RVA: 0x0017BD6D File Offset: 0x00179F6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F58 RID: 8024
		// (get) Token: 0x06009BFA RID: 39930 RVA: 0x0017BD70 File Offset: 0x00179F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GaSwitchCommonEnemyProCampResponse.Descriptor;
			}
		}

		// Token: 0x06009BFB RID: 39931 RVA: 0x0017BD77 File Offset: 0x00179F77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GaSwitchCommonEnemyProCampResponse()
		{
		}

		// Token: 0x06009BFC RID: 39932 RVA: 0x0017BD7F File Offset: 0x00179F7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GaSwitchCommonEnemyProCampResponse(GaSwitchCommonEnemyProCampResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009BFD RID: 39933 RVA: 0x0017BDA4 File Offset: 0x00179FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GaSwitchCommonEnemyProCampResponse Clone()
		{
			return new GaSwitchCommonEnemyProCampResponse(this);
		}

		// Token: 0x17001F59 RID: 8025
		// (get) Token: 0x06009BFE RID: 39934 RVA: 0x0017BDAC File Offset: 0x00179FAC
		// (set) Token: 0x06009BFF RID: 39935 RVA: 0x0017BDB4 File Offset: 0x00179FB4
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

		// Token: 0x06009C00 RID: 39936 RVA: 0x0017BDBD File Offset: 0x00179FBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GaSwitchCommonEnemyProCampResponse);
		}

		// Token: 0x06009C01 RID: 39937 RVA: 0x0017BDCB File Offset: 0x00179FCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GaSwitchCommonEnemyProCampResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009C02 RID: 39938 RVA: 0x0017BDFC File Offset: 0x00179FFC
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

		// Token: 0x06009C03 RID: 39939 RVA: 0x0017BE41 File Offset: 0x0017A041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009C04 RID: 39940 RVA: 0x0017BE4E File Offset: 0x0017A04E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009C05 RID: 39941 RVA: 0x0017BE57 File Offset: 0x0017A057
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009C06 RID: 39942 RVA: 0x0017BE8C File Offset: 0x0017A08C
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

		// Token: 0x06009C07 RID: 39943 RVA: 0x0017BECA File Offset: 0x0017A0CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GaSwitchCommonEnemyProCampResponse other)
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

		// Token: 0x06009C08 RID: 39944 RVA: 0x0017BEFB File Offset: 0x0017A0FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009C09 RID: 39945 RVA: 0x0017BF04 File Offset: 0x0017A104
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040049EC RID: 18924
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049ED RID: 18925
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x040049EE RID: 18926
		private ErrorCode errorCode_;
	}
}
