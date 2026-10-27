using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006B4 RID: 1716
	[NetMessage(EMessageId.GaSwitchCommonEnemyProCampResponse)]
	public sealed class GaSwitchCommonEnemyProCampResponse : IMessage<GaSwitchCommonEnemyProCampResponse>, IMessage, IEquatable<GaSwitchCommonEnemyProCampResponse>, IDeepCloneable<GaSwitchCommonEnemyProCampResponse>, IBufferMessage
	{
		// Token: 0x06009D4E RID: 40270 RVA: 0x0017E796 File Offset: 0x0017C996
		[NullableContext(1)]
		public static GaSwitchCommonEnemyProCampResponse Create()
		{
			return new GaSwitchCommonEnemyProCampResponse();
		}

		// Token: 0x17001FA1 RID: 8097
		// (get) Token: 0x06009D4F RID: 40271 RVA: 0x0017E79D File Offset: 0x0017C99D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FA2 RID: 8098
		// (get) Token: 0x06009D50 RID: 40272 RVA: 0x0017E7A0 File Offset: 0x0017C9A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GaSwitchCommonEnemyProCampResponse.Descriptor;
			}
		}

		// Token: 0x06009D51 RID: 40273 RVA: 0x0017E7A7 File Offset: 0x0017C9A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GaSwitchCommonEnemyProCampResponse()
		{
		}

		// Token: 0x06009D52 RID: 40274 RVA: 0x0017E7AF File Offset: 0x0017C9AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GaSwitchCommonEnemyProCampResponse(GaSwitchCommonEnemyProCampResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009D53 RID: 40275 RVA: 0x0017E7D4 File Offset: 0x0017C9D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GaSwitchCommonEnemyProCampResponse Clone()
		{
			return new GaSwitchCommonEnemyProCampResponse(this);
		}

		// Token: 0x17001FA3 RID: 8099
		// (get) Token: 0x06009D54 RID: 40276 RVA: 0x0017E7DC File Offset: 0x0017C9DC
		// (set) Token: 0x06009D55 RID: 40277 RVA: 0x0017E7E4 File Offset: 0x0017C9E4
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

		// Token: 0x06009D56 RID: 40278 RVA: 0x0017E7ED File Offset: 0x0017C9ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GaSwitchCommonEnemyProCampResponse);
		}

		// Token: 0x06009D57 RID: 40279 RVA: 0x0017E7FB File Offset: 0x0017C9FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GaSwitchCommonEnemyProCampResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009D58 RID: 40280 RVA: 0x0017E82C File Offset: 0x0017CA2C
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

		// Token: 0x06009D59 RID: 40281 RVA: 0x0017E871 File Offset: 0x0017CA71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009D5A RID: 40282 RVA: 0x0017E87E File Offset: 0x0017CA7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009D5B RID: 40283 RVA: 0x0017E887 File Offset: 0x0017CA87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009D5C RID: 40284 RVA: 0x0017E8BC File Offset: 0x0017CABC
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

		// Token: 0x06009D5D RID: 40285 RVA: 0x0017E8FA File Offset: 0x0017CAFA
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

		// Token: 0x06009D5E RID: 40286 RVA: 0x0017E92B File Offset: 0x0017CB2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009D5F RID: 40287 RVA: 0x0017E934 File Offset: 0x0017CB34
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040049F3 RID: 18931
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049F4 RID: 18932
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x040049F5 RID: 18933
		private ErrorCode errorCode_;
	}
}
