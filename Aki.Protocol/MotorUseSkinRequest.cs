using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AA4 RID: 2724
	[NetMessage(EMessageId.MotorUseSkinRequest)]
	public sealed class MotorUseSkinRequest : IMessage<MotorUseSkinRequest>, IMessage, IEquatable<MotorUseSkinRequest>, IDeepCloneable<MotorUseSkinRequest>, IBufferMessage
	{
		// Token: 0x0600ED65 RID: 60773 RVA: 0x0022AA03 File Offset: 0x00228C03
		[NullableContext(1)]
		public static MotorUseSkinRequest Create()
		{
			return new MotorUseSkinRequest();
		}

		// Token: 0x17003036 RID: 12342
		// (get) Token: 0x0600ED66 RID: 60774 RVA: 0x0022AA0A File Offset: 0x00228C0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003037 RID: 12343
		// (get) Token: 0x0600ED67 RID: 60775 RVA: 0x0022AA0D File Offset: 0x00228C0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorUseSkinRequest.Descriptor;
			}
		}

		// Token: 0x0600ED68 RID: 60776 RVA: 0x0022AA14 File Offset: 0x00228C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorUseSkinRequest()
		{
		}

		// Token: 0x0600ED69 RID: 60777 RVA: 0x0022AA1C File Offset: 0x00228C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorUseSkinRequest(MotorUseSkinRequest other) : this()
		{
			this.skinId_ = other.skinId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ED6A RID: 60778 RVA: 0x0022AA41 File Offset: 0x00228C41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorUseSkinRequest Clone()
		{
			return new MotorUseSkinRequest(this);
		}

		// Token: 0x17003038 RID: 12344
		// (get) Token: 0x0600ED6B RID: 60779 RVA: 0x0022AA49 File Offset: 0x00228C49
		// (set) Token: 0x0600ED6C RID: 60780 RVA: 0x0022AA51 File Offset: 0x00228C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkinId
		{
			get
			{
				return this.skinId_;
			}
			set
			{
				this.skinId_ = value;
			}
		}

		// Token: 0x0600ED6D RID: 60781 RVA: 0x0022AA5A File Offset: 0x00228C5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorUseSkinRequest);
		}

		// Token: 0x0600ED6E RID: 60782 RVA: 0x0022AA68 File Offset: 0x00228C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorUseSkinRequest other)
		{
			return other != null && (other == this || (this.SkinId == other.SkinId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ED6F RID: 60783 RVA: 0x0022AA98 File Offset: 0x00228C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkinId != 0)
			{
				num ^= this.SkinId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ED70 RID: 60784 RVA: 0x0022AAD7 File Offset: 0x00228CD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ED71 RID: 60785 RVA: 0x0022AAE4 File Offset: 0x00228CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ED72 RID: 60786 RVA: 0x0022AAED File Offset: 0x00228CED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkinId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ED73 RID: 60787 RVA: 0x0022AB20 File Offset: 0x00228D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ED74 RID: 60788 RVA: 0x0022AB5E File Offset: 0x00228D5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorUseSkinRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkinId != 0)
			{
				this.SkinId = other.SkinId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ED75 RID: 60789 RVA: 0x0022AB8F File Offset: 0x00228D8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ED76 RID: 60790 RVA: 0x0022AB98 File Offset: 0x00228D98
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SkinId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400607C RID: 24700
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400607D RID: 24701
		public const int SkinIdFieldNumber = 14;

		// Token: 0x0400607E RID: 24702
		private int skinId_;
	}
}
