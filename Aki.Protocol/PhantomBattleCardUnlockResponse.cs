using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C58 RID: 3160
	[NetMessage(EMessageId.PhantomBattleCardUnlockResponse)]
	public sealed class PhantomBattleCardUnlockResponse : IMessage<PhantomBattleCardUnlockResponse>, IMessage, IEquatable<PhantomBattleCardUnlockResponse>, IDeepCloneable<PhantomBattleCardUnlockResponse>, IBufferMessage
	{
		// Token: 0x06011274 RID: 70260 RVA: 0x002835A1 File Offset: 0x002817A1
		[NullableContext(1)]
		public static PhantomBattleCardUnlockResponse Create()
		{
			return new PhantomBattleCardUnlockResponse();
		}

		// Token: 0x170038B5 RID: 14517
		// (get) Token: 0x06011275 RID: 70261 RVA: 0x002835A8 File Offset: 0x002817A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038B6 RID: 14518
		// (get) Token: 0x06011276 RID: 70262 RVA: 0x002835AB File Offset: 0x002817AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardUnlockResponse.Descriptor;
			}
		}

		// Token: 0x06011277 RID: 70263 RVA: 0x002835B2 File Offset: 0x002817B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardUnlockResponse()
		{
		}

		// Token: 0x06011278 RID: 70264 RVA: 0x002835BA File Offset: 0x002817BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardUnlockResponse(PhantomBattleCardUnlockResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011279 RID: 70265 RVA: 0x002835DF File Offset: 0x002817DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardUnlockResponse Clone()
		{
			return new PhantomBattleCardUnlockResponse(this);
		}

		// Token: 0x170038B7 RID: 14519
		// (get) Token: 0x0601127A RID: 70266 RVA: 0x002835E7 File Offset: 0x002817E7
		// (set) Token: 0x0601127B RID: 70267 RVA: 0x002835EF File Offset: 0x002817EF
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

		// Token: 0x0601127C RID: 70268 RVA: 0x002835F8 File Offset: 0x002817F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardUnlockResponse);
		}

		// Token: 0x0601127D RID: 70269 RVA: 0x00283606 File Offset: 0x00281806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardUnlockResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601127E RID: 70270 RVA: 0x00283634 File Offset: 0x00281834
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

		// Token: 0x0601127F RID: 70271 RVA: 0x00283679 File Offset: 0x00281879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011280 RID: 70272 RVA: 0x00283686 File Offset: 0x00281886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011281 RID: 70273 RVA: 0x0028368F File Offset: 0x0028188F
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

		// Token: 0x06011282 RID: 70274 RVA: 0x002836C4 File Offset: 0x002818C4
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

		// Token: 0x06011283 RID: 70275 RVA: 0x00283702 File Offset: 0x00281902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardUnlockResponse other)
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

		// Token: 0x06011284 RID: 70276 RVA: 0x00283733 File Offset: 0x00281933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011285 RID: 70277 RVA: 0x0028373C File Offset: 0x0028193C
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

		// Token: 0x04006CF5 RID: 27893
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006CF6 RID: 27894
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04006CF7 RID: 27895
		private ErrorCode errorCode_;
	}
}
