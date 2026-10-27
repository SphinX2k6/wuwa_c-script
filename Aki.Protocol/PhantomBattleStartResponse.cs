using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CBE RID: 3262
	[NetMessage(EMessageId.PhantomBattleStartResponse)]
	public sealed class PhantomBattleStartResponse : IMessage<PhantomBattleStartResponse>, IMessage, IEquatable<PhantomBattleStartResponse>, IDeepCloneable<PhantomBattleStartResponse>, IBufferMessage
	{
		// Token: 0x06011AAF RID: 72367 RVA: 0x00296556 File Offset: 0x00294756
		[NullableContext(1)]
		public static PhantomBattleStartResponse Create()
		{
			return new PhantomBattleStartResponse();
		}

		// Token: 0x17003A8C RID: 14988
		// (get) Token: 0x06011AB0 RID: 72368 RVA: 0x0029655D File Offset: 0x0029475D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A8D RID: 14989
		// (get) Token: 0x06011AB1 RID: 72369 RVA: 0x00296560 File Offset: 0x00294760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleStartResponse.Descriptor;
			}
		}

		// Token: 0x06011AB2 RID: 72370 RVA: 0x00296567 File Offset: 0x00294767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleStartResponse()
		{
		}

		// Token: 0x06011AB3 RID: 72371 RVA: 0x0029656F File Offset: 0x0029476F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleStartResponse(PhantomBattleStartResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011AB4 RID: 72372 RVA: 0x00296594 File Offset: 0x00294794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleStartResponse Clone()
		{
			return new PhantomBattleStartResponse(this);
		}

		// Token: 0x17003A8E RID: 14990
		// (get) Token: 0x06011AB5 RID: 72373 RVA: 0x0029659C File Offset: 0x0029479C
		// (set) Token: 0x06011AB6 RID: 72374 RVA: 0x002965A4 File Offset: 0x002947A4
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

		// Token: 0x06011AB7 RID: 72375 RVA: 0x002965AD File Offset: 0x002947AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleStartResponse);
		}

		// Token: 0x06011AB8 RID: 72376 RVA: 0x002965BB File Offset: 0x002947BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleStartResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011AB9 RID: 72377 RVA: 0x002965EC File Offset: 0x002947EC
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

		// Token: 0x06011ABA RID: 72378 RVA: 0x00296631 File Offset: 0x00294831
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011ABB RID: 72379 RVA: 0x0029663E File Offset: 0x0029483E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011ABC RID: 72380 RVA: 0x00296647 File Offset: 0x00294847
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011ABD RID: 72381 RVA: 0x0029667C File Offset: 0x0029487C
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

		// Token: 0x06011ABE RID: 72382 RVA: 0x002966BA File Offset: 0x002948BA
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

		// Token: 0x06011ABF RID: 72383 RVA: 0x002966EB File Offset: 0x002948EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011AC0 RID: 72384 RVA: 0x002966F4 File Offset: 0x002948F4
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006F36 RID: 28470
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F37 RID: 28471
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04006F38 RID: 28472
		private ErrorCode errorCode_;
	}
}
