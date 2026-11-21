using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D8A RID: 3466
	[NetMessage(EMessageId.PlayerMotionRequest)]
	public sealed class PlayerMotionRequest : IMessage<PlayerMotionRequest>, IMessage, IEquatable<PlayerMotionRequest>, IDeepCloneable<PlayerMotionRequest>, IBufferMessage
	{
		// Token: 0x06012B5A RID: 76634 RVA: 0x002BB7BF File Offset: 0x002B99BF
		[NullableContext(1)]
		public static PlayerMotionRequest Create()
		{
			return new PlayerMotionRequest();
		}

		// Token: 0x17003E17 RID: 15895
		// (get) Token: 0x06012B5B RID: 76635 RVA: 0x002BB7C6 File Offset: 0x002B99C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E18 RID: 15896
		// (get) Token: 0x06012B5C RID: 76636 RVA: 0x002BB7C9 File Offset: 0x002B99C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerMotionRequest.Descriptor;
			}
		}

		// Token: 0x06012B5D RID: 76637 RVA: 0x002BB7D0 File Offset: 0x002B99D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerMotionRequest()
		{
		}

		// Token: 0x06012B5E RID: 76638 RVA: 0x002BB7D8 File Offset: 0x002B99D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerMotionRequest(PlayerMotionRequest other) : this()
		{
			this.motion_ = other.motion_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012B5F RID: 76639 RVA: 0x002BB7FD File Offset: 0x002B99FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerMotionRequest Clone()
		{
			return new PlayerMotionRequest(this);
		}

		// Token: 0x17003E19 RID: 15897
		// (get) Token: 0x06012B60 RID: 76640 RVA: 0x002BB805 File Offset: 0x002B9A05
		// (set) Token: 0x06012B61 RID: 76641 RVA: 0x002BB80D File Offset: 0x002B9A0D
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

		// Token: 0x06012B62 RID: 76642 RVA: 0x002BB816 File Offset: 0x002B9A16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerMotionRequest);
		}

		// Token: 0x06012B63 RID: 76643 RVA: 0x002BB824 File Offset: 0x002B9A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerMotionRequest other)
		{
			return other != null && (other == this || (this.Motion == other.Motion && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012B64 RID: 76644 RVA: 0x002BB854 File Offset: 0x002B9A54
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

		// Token: 0x06012B65 RID: 76645 RVA: 0x002BB899 File Offset: 0x002B9A99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012B66 RID: 76646 RVA: 0x002BB8A6 File Offset: 0x002B9AA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012B67 RID: 76647 RVA: 0x002BB8AF File Offset: 0x002B9AAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Motion != MotionType.Spurt)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Motion);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012B68 RID: 76648 RVA: 0x002BB8E4 File Offset: 0x002B9AE4
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

		// Token: 0x06012B69 RID: 76649 RVA: 0x002BB922 File Offset: 0x002B9B22
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

		// Token: 0x06012B6A RID: 76650 RVA: 0x002BB953 File Offset: 0x002B9B53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012B6B RID: 76651 RVA: 0x002BB95C File Offset: 0x002B9B5C
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
					this.Motion = (MotionType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007472 RID: 29810
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007473 RID: 29811
		public const int MotionFieldNumber = 5;

		// Token: 0x04007474 RID: 29812
		private MotionType motion_;
	}
}
