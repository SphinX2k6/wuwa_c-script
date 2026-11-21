using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C2D RID: 3117
	[NetMessage(EMessageId.PhantomBattleBvBLoadingFinishResponse)]
	public sealed class PhantomBattleBvBLoadingFinishResponse : IMessage<PhantomBattleBvBLoadingFinishResponse>, IMessage, IEquatable<PhantomBattleBvBLoadingFinishResponse>, IDeepCloneable<PhantomBattleBvBLoadingFinishResponse>, IBufferMessage
	{
		// Token: 0x06010ECC RID: 69324 RVA: 0x0027AA0E File Offset: 0x00278C0E
		[NullableContext(1)]
		public static PhantomBattleBvBLoadingFinishResponse Create()
		{
			return new PhantomBattleBvBLoadingFinishResponse();
		}

		// Token: 0x170037E0 RID: 14304
		// (get) Token: 0x06010ECD RID: 69325 RVA: 0x0027AA15 File Offset: 0x00278C15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037E1 RID: 14305
		// (get) Token: 0x06010ECE RID: 69326 RVA: 0x0027AA18 File Offset: 0x00278C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBvBLoadingFinishResponse.Descriptor;
			}
		}

		// Token: 0x06010ECF RID: 69327 RVA: 0x0027AA1F File Offset: 0x00278C1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBvBLoadingFinishResponse()
		{
		}

		// Token: 0x06010ED0 RID: 69328 RVA: 0x0027AA27 File Offset: 0x00278C27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBvBLoadingFinishResponse(PhantomBattleBvBLoadingFinishResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010ED1 RID: 69329 RVA: 0x0027AA4C File Offset: 0x00278C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBvBLoadingFinishResponse Clone()
		{
			return new PhantomBattleBvBLoadingFinishResponse(this);
		}

		// Token: 0x170037E2 RID: 14306
		// (get) Token: 0x06010ED2 RID: 69330 RVA: 0x0027AA54 File Offset: 0x00278C54
		// (set) Token: 0x06010ED3 RID: 69331 RVA: 0x0027AA5C File Offset: 0x00278C5C
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

		// Token: 0x06010ED4 RID: 69332 RVA: 0x0027AA65 File Offset: 0x00278C65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBvBLoadingFinishResponse);
		}

		// Token: 0x06010ED5 RID: 69333 RVA: 0x0027AA73 File Offset: 0x00278C73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBvBLoadingFinishResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010ED6 RID: 69334 RVA: 0x0027AAA4 File Offset: 0x00278CA4
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

		// Token: 0x06010ED7 RID: 69335 RVA: 0x0027AAE9 File Offset: 0x00278CE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010ED8 RID: 69336 RVA: 0x0027AAF6 File Offset: 0x00278CF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010ED9 RID: 69337 RVA: 0x0027AAFF File Offset: 0x00278CFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010EDA RID: 69338 RVA: 0x0027AB34 File Offset: 0x00278D34
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

		// Token: 0x06010EDB RID: 69339 RVA: 0x0027AB72 File Offset: 0x00278D72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleBvBLoadingFinishResponse other)
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

		// Token: 0x06010EDC RID: 69340 RVA: 0x0027ABA3 File Offset: 0x00278DA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010EDD RID: 69341 RVA: 0x0027ABAC File Offset: 0x00278DAC
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006BB5 RID: 27573
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006BB6 RID: 27574
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04006BB7 RID: 27575
		private ErrorCode errorCode_;
	}
}
