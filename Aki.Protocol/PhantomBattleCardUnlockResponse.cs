using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C68 RID: 3176
	[NetMessage(EMessageId.PhantomBattleCardUnlockResponse)]
	public sealed class PhantomBattleCardUnlockResponse : IMessage<PhantomBattleCardUnlockResponse>, IMessage, IEquatable<PhantomBattleCardUnlockResponse>, IDeepCloneable<PhantomBattleCardUnlockResponse>, IBufferMessage
	{
		// Token: 0x06011374 RID: 70516 RVA: 0x00285311 File Offset: 0x00283511
		[NullableContext(1)]
		public static PhantomBattleCardUnlockResponse Create()
		{
			return new PhantomBattleCardUnlockResponse();
		}

		// Token: 0x170038EC RID: 14572
		// (get) Token: 0x06011375 RID: 70517 RVA: 0x00285318 File Offset: 0x00283518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038ED RID: 14573
		// (get) Token: 0x06011376 RID: 70518 RVA: 0x0028531B File Offset: 0x0028351B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardUnlockResponse.Descriptor;
			}
		}

		// Token: 0x06011377 RID: 70519 RVA: 0x00285322 File Offset: 0x00283522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardUnlockResponse()
		{
		}

		// Token: 0x06011378 RID: 70520 RVA: 0x0028532A File Offset: 0x0028352A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardUnlockResponse(PhantomBattleCardUnlockResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011379 RID: 70521 RVA: 0x0028534F File Offset: 0x0028354F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardUnlockResponse Clone()
		{
			return new PhantomBattleCardUnlockResponse(this);
		}

		// Token: 0x170038EE RID: 14574
		// (get) Token: 0x0601137A RID: 70522 RVA: 0x00285357 File Offset: 0x00283557
		// (set) Token: 0x0601137B RID: 70523 RVA: 0x0028535F File Offset: 0x0028355F
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

		// Token: 0x0601137C RID: 70524 RVA: 0x00285368 File Offset: 0x00283568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardUnlockResponse);
		}

		// Token: 0x0601137D RID: 70525 RVA: 0x00285376 File Offset: 0x00283576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardUnlockResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601137E RID: 70526 RVA: 0x002853A4 File Offset: 0x002835A4
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

		// Token: 0x0601137F RID: 70527 RVA: 0x002853E9 File Offset: 0x002835E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011380 RID: 70528 RVA: 0x002853F6 File Offset: 0x002835F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011381 RID: 70529 RVA: 0x002853FF File Offset: 0x002835FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011382 RID: 70530 RVA: 0x00285434 File Offset: 0x00283634
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

		// Token: 0x06011383 RID: 70531 RVA: 0x00285472 File Offset: 0x00283672
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

		// Token: 0x06011384 RID: 70532 RVA: 0x002854A3 File Offset: 0x002836A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011385 RID: 70533 RVA: 0x002854AC File Offset: 0x002836AC
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006CE1 RID: 27873
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006CE2 RID: 27874
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04006CE3 RID: 27875
		private ErrorCode errorCode_;
	}
}
