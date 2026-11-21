using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CAE RID: 3246
	[NetMessage(EMessageId.PhantomBattleStartResponse)]
	public sealed class PhantomBattleStartResponse : IMessage<PhantomBattleStartResponse>, IMessage, IEquatable<PhantomBattleStartResponse>, IDeepCloneable<PhantomBattleStartResponse>, IBufferMessage
	{
		// Token: 0x060119AF RID: 72111 RVA: 0x002947F6 File Offset: 0x002929F6
		[NullableContext(1)]
		public static PhantomBattleStartResponse Create()
		{
			return new PhantomBattleStartResponse();
		}

		// Token: 0x17003A55 RID: 14933
		// (get) Token: 0x060119B0 RID: 72112 RVA: 0x002947FD File Offset: 0x002929FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A56 RID: 14934
		// (get) Token: 0x060119B1 RID: 72113 RVA: 0x00294800 File Offset: 0x00292A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleStartResponse.Descriptor;
			}
		}

		// Token: 0x060119B2 RID: 72114 RVA: 0x00294807 File Offset: 0x00292A07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleStartResponse()
		{
		}

		// Token: 0x060119B3 RID: 72115 RVA: 0x0029480F File Offset: 0x00292A0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleStartResponse(PhantomBattleStartResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060119B4 RID: 72116 RVA: 0x00294834 File Offset: 0x00292A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleStartResponse Clone()
		{
			return new PhantomBattleStartResponse(this);
		}

		// Token: 0x17003A57 RID: 14935
		// (get) Token: 0x060119B5 RID: 72117 RVA: 0x0029483C File Offset: 0x00292A3C
		// (set) Token: 0x060119B6 RID: 72118 RVA: 0x00294844 File Offset: 0x00292A44
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

		// Token: 0x060119B7 RID: 72119 RVA: 0x0029484D File Offset: 0x00292A4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleStartResponse);
		}

		// Token: 0x060119B8 RID: 72120 RVA: 0x0029485B File Offset: 0x00292A5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleStartResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060119B9 RID: 72121 RVA: 0x0029488C File Offset: 0x00292A8C
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

		// Token: 0x060119BA RID: 72122 RVA: 0x002948D1 File Offset: 0x00292AD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060119BB RID: 72123 RVA: 0x002948DE File Offset: 0x00292ADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060119BC RID: 72124 RVA: 0x002948E7 File Offset: 0x00292AE7
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

		// Token: 0x060119BD RID: 72125 RVA: 0x0029491C File Offset: 0x00292B1C
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

		// Token: 0x060119BE RID: 72126 RVA: 0x0029495A File Offset: 0x00292B5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleStartResponse other)
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

		// Token: 0x060119BF RID: 72127 RVA: 0x0029498B File Offset: 0x00292B8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060119C0 RID: 72128 RVA: 0x00294994 File Offset: 0x00292B94
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

		// Token: 0x04006F4A RID: 28490
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F4B RID: 28491
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04006F4C RID: 28492
		private ErrorCode errorCode_;
	}
}
