using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C9C RID: 3228
	[NetMessage(EMessageId.PhantomBattleNpcShowOverResponse)]
	public sealed class PhantomBattleNpcShowOverResponse : IMessage<PhantomBattleNpcShowOverResponse>, IMessage, IEquatable<PhantomBattleNpcShowOverResponse>, IDeepCloneable<PhantomBattleNpcShowOverResponse>, IBufferMessage
	{
		// Token: 0x060117E5 RID: 71653 RVA: 0x002901E2 File Offset: 0x0028E3E2
		[NullableContext(1)]
		public static PhantomBattleNpcShowOverResponse Create()
		{
			return new PhantomBattleNpcShowOverResponse();
		}

		// Token: 0x170039F2 RID: 14834
		// (get) Token: 0x060117E6 RID: 71654 RVA: 0x002901E9 File Offset: 0x0028E3E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039F3 RID: 14835
		// (get) Token: 0x060117E7 RID: 71655 RVA: 0x002901EC File Offset: 0x0028E3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleNpcShowOverResponse.Descriptor;
			}
		}

		// Token: 0x060117E8 RID: 71656 RVA: 0x002901F3 File Offset: 0x0028E3F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleNpcShowOverResponse()
		{
		}

		// Token: 0x060117E9 RID: 71657 RVA: 0x002901FB File Offset: 0x0028E3FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleNpcShowOverResponse(PhantomBattleNpcShowOverResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060117EA RID: 71658 RVA: 0x00290220 File Offset: 0x0028E420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleNpcShowOverResponse Clone()
		{
			return new PhantomBattleNpcShowOverResponse(this);
		}

		// Token: 0x170039F4 RID: 14836
		// (get) Token: 0x060117EB RID: 71659 RVA: 0x00290228 File Offset: 0x0028E428
		// (set) Token: 0x060117EC RID: 71660 RVA: 0x00290230 File Offset: 0x0028E430
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

		// Token: 0x060117ED RID: 71661 RVA: 0x00290239 File Offset: 0x0028E439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleNpcShowOverResponse);
		}

		// Token: 0x060117EE RID: 71662 RVA: 0x00290247 File Offset: 0x0028E447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleNpcShowOverResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060117EF RID: 71663 RVA: 0x00290278 File Offset: 0x0028E478
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

		// Token: 0x060117F0 RID: 71664 RVA: 0x002902BD File Offset: 0x0028E4BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060117F1 RID: 71665 RVA: 0x002902CA File Offset: 0x0028E4CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060117F2 RID: 71666 RVA: 0x002902D3 File Offset: 0x0028E4D3
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

		// Token: 0x060117F3 RID: 71667 RVA: 0x00290304 File Offset: 0x0028E504
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

		// Token: 0x060117F4 RID: 71668 RVA: 0x00290342 File Offset: 0x0028E542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleNpcShowOverResponse other)
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

		// Token: 0x060117F5 RID: 71669 RVA: 0x00290373 File Offset: 0x0028E573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060117F6 RID: 71670 RVA: 0x0029037C File Offset: 0x0028E57C
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

		// Token: 0x04006E59 RID: 28249
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E5A RID: 28250
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04006E5B RID: 28251
		private ErrorCode errorCode_;
	}
}
