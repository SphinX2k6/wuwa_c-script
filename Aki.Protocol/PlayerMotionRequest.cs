using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D9A RID: 3482
	[NetMessage(EMessageId.PlayerMotionRequest)]
	public sealed class PlayerMotionRequest : IMessage<PlayerMotionRequest>, IMessage, IEquatable<PlayerMotionRequest>, IDeepCloneable<PlayerMotionRequest>, IBufferMessage
	{
		// Token: 0x06012C56 RID: 76886 RVA: 0x002BD3E3 File Offset: 0x002BB5E3
		[NullableContext(1)]
		public static PlayerMotionRequest Create()
		{
			return new PlayerMotionRequest();
		}

		// Token: 0x17003E4C RID: 15948
		// (get) Token: 0x06012C57 RID: 76887 RVA: 0x002BD3EA File Offset: 0x002BB5EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E4D RID: 15949
		// (get) Token: 0x06012C58 RID: 76888 RVA: 0x002BD3ED File Offset: 0x002BB5ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerMotionRequest.Descriptor;
			}
		}

		// Token: 0x06012C59 RID: 76889 RVA: 0x002BD3F4 File Offset: 0x002BB5F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerMotionRequest()
		{
		}

		// Token: 0x06012C5A RID: 76890 RVA: 0x002BD3FC File Offset: 0x002BB5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerMotionRequest(PlayerMotionRequest other) : this()
		{
			this.motion_ = other.motion_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012C5B RID: 76891 RVA: 0x002BD421 File Offset: 0x002BB621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerMotionRequest Clone()
		{
			return new PlayerMotionRequest(this);
		}

		// Token: 0x17003E4E RID: 15950
		// (get) Token: 0x06012C5C RID: 76892 RVA: 0x002BD429 File Offset: 0x002BB629
		// (set) Token: 0x06012C5D RID: 76893 RVA: 0x002BD431 File Offset: 0x002BB631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotionType Motion
		{
			get
			{
				return this.motion_;
			}
			set
			{
				this.motion_ = value;
			}
		}

		// Token: 0x06012C5E RID: 76894 RVA: 0x002BD43A File Offset: 0x002BB63A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerMotionRequest);
		}

		// Token: 0x06012C5F RID: 76895 RVA: 0x002BD448 File Offset: 0x002BB648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerMotionRequest other)
		{
			return other != null && (other == this || (this.Motion == other.Motion && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012C60 RID: 76896 RVA: 0x002BD478 File Offset: 0x002BB678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Motion != MotionType.Spurt)
			{
				num ^= this.Motion.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012C61 RID: 76897 RVA: 0x002BD4BD File Offset: 0x002BB6BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012C62 RID: 76898 RVA: 0x002BD4CA File Offset: 0x002BB6CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012C63 RID: 76899 RVA: 0x002BD4D3 File Offset: 0x002BB6D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Motion != MotionType.Spurt)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.Motion);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012C64 RID: 76900 RVA: 0x002BD508 File Offset: 0x002BB708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Motion != MotionType.Spurt)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Motion);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012C65 RID: 76901 RVA: 0x002BD546 File Offset: 0x002BB746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerMotionRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Motion != MotionType.Spurt)
			{
				this.Motion = other.Motion;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012C66 RID: 76902 RVA: 0x002BD577 File Offset: 0x002BB777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012C67 RID: 76903 RVA: 0x002BD580 File Offset: 0x002BB780
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Motion = (MotionType)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400745A RID: 29786
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400745B RID: 29787
		public const int MotionFieldNumber = 6;

		// Token: 0x0400745C RID: 29788
		private MotionType motion_;
	}
}
