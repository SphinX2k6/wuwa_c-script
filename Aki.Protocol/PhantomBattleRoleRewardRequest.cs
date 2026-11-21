using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C9A RID: 3226
	[NetMessage(EMessageId.PhantomBattleRoleRewardRequest)]
	public sealed class PhantomBattleRoleRewardRequest : IMessage<PhantomBattleRoleRewardRequest>, IMessage, IEquatable<PhantomBattleRoleRewardRequest>, IDeepCloneable<PhantomBattleRoleRewardRequest>, IBufferMessage
	{
		// Token: 0x06011813 RID: 71699 RVA: 0x00290F1D File Offset: 0x0028F11D
		[NullableContext(1)]
		public static PhantomBattleRoleRewardRequest Create()
		{
			return new PhantomBattleRoleRewardRequest();
		}

		// Token: 0x170039FE RID: 14846
		// (get) Token: 0x06011814 RID: 71700 RVA: 0x00290F24 File Offset: 0x0028F124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039FF RID: 14847
		// (get) Token: 0x06011815 RID: 71701 RVA: 0x00290F27 File Offset: 0x0028F127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleRoleRewardRequest.Descriptor;
			}
		}

		// Token: 0x06011816 RID: 71702 RVA: 0x00290F2E File Offset: 0x0028F12E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoleRewardRequest()
		{
		}

		// Token: 0x06011817 RID: 71703 RVA: 0x00290F36 File Offset: 0x0028F136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoleRewardRequest(PhantomBattleRoleRewardRequest other) : this()
		{
			this.phantomBattleRoleId_ = other.phantomBattleRoleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011818 RID: 71704 RVA: 0x00290F5B File Offset: 0x0028F15B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoleRewardRequest Clone()
		{
			return new PhantomBattleRoleRewardRequest(this);
		}

		// Token: 0x17003A00 RID: 14848
		// (get) Token: 0x06011819 RID: 71705 RVA: 0x00290F63 File Offset: 0x0028F163
		// (set) Token: 0x0601181A RID: 71706 RVA: 0x00290F6B File Offset: 0x0028F16B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PhantomBattleRoleId
		{
			get
			{
				return this.phantomBattleRoleId_;
			}
			set
			{
				this.phantomBattleRoleId_ = value;
			}
		}

		// Token: 0x0601181B RID: 71707 RVA: 0x00290F74 File Offset: 0x0028F174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleRoleRewardRequest);
		}

		// Token: 0x0601181C RID: 71708 RVA: 0x00290F82 File Offset: 0x0028F182
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleRoleRewardRequest other)
		{
			return other != null && (other == this || (this.PhantomBattleRoleId == other.PhantomBattleRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601181D RID: 71709 RVA: 0x00290FB0 File Offset: 0x0028F1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PhantomBattleRoleId != 0)
			{
				num ^= this.PhantomBattleRoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601181E RID: 71710 RVA: 0x00290FEF File Offset: 0x0028F1EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601181F RID: 71711 RVA: 0x00290FFC File Offset: 0x0028F1FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011820 RID: 71712 RVA: 0x00291005 File Offset: 0x0028F205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PhantomBattleRoleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PhantomBattleRoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011821 RID: 71713 RVA: 0x00291038 File Offset: 0x0028F238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PhantomBattleRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PhantomBattleRoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011822 RID: 71714 RVA: 0x00291076 File Offset: 0x0028F276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleRoleRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PhantomBattleRoleId != 0)
			{
				this.PhantomBattleRoleId = other.PhantomBattleRoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011823 RID: 71715 RVA: 0x002910A7 File Offset: 0x0028F2A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011824 RID: 71716 RVA: 0x002910B0 File Offset: 0x0028F2B0
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PhantomBattleRoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006ECE RID: 28366
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006ECF RID: 28367
		public const int PhantomBattleRoleIdFieldNumber = 2;

		// Token: 0x04006ED0 RID: 28368
		private int phantomBattleRoleId_;
	}
}
