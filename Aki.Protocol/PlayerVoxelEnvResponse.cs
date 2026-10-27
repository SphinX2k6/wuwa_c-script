using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DBC RID: 3516
	[NetMessage(EMessageId.PlayerVoxelEnvResponse)]
	public sealed class PlayerVoxelEnvResponse : IMessage<PlayerVoxelEnvResponse>, IMessage, IEquatable<PlayerVoxelEnvResponse>, IDeepCloneable<PlayerVoxelEnvResponse>, IBufferMessage
	{
		// Token: 0x06012F0B RID: 77579 RVA: 0x002C32F1 File Offset: 0x002C14F1
		[NullableContext(1)]
		public static PlayerVoxelEnvResponse Create()
		{
			return new PlayerVoxelEnvResponse();
		}

		// Token: 0x17003EDF RID: 16095
		// (get) Token: 0x06012F0C RID: 77580 RVA: 0x002C32F8 File Offset: 0x002C14F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EE0 RID: 16096
		// (get) Token: 0x06012F0D RID: 77581 RVA: 0x002C32FB File Offset: 0x002C14FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerVoxelEnvResponse.Descriptor;
			}
		}

		// Token: 0x06012F0E RID: 77582 RVA: 0x002C3302 File Offset: 0x002C1502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerVoxelEnvResponse()
		{
		}

		// Token: 0x06012F0F RID: 77583 RVA: 0x002C330A File Offset: 0x002C150A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerVoxelEnvResponse(PlayerVoxelEnvResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.voxelEnv_ = other.voxelEnv_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012F10 RID: 77584 RVA: 0x002C333B File Offset: 0x002C153B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerVoxelEnvResponse Clone()
		{
			return new PlayerVoxelEnvResponse(this);
		}

		// Token: 0x17003EE1 RID: 16097
		// (get) Token: 0x06012F11 RID: 77585 RVA: 0x002C3343 File Offset: 0x002C1543
		// (set) Token: 0x06012F12 RID: 77586 RVA: 0x002C334B File Offset: 0x002C154B
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

		// Token: 0x17003EE2 RID: 16098
		// (get) Token: 0x06012F13 RID: 77587 RVA: 0x002C3354 File Offset: 0x002C1554
		// (set) Token: 0x06012F14 RID: 77588 RVA: 0x002C335C File Offset: 0x002C155C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int VoxelEnv
		{
			get
			{
				return this.voxelEnv_;
			}
			set
			{
				this.voxelEnv_ = value;
			}
		}

		// Token: 0x06012F15 RID: 77589 RVA: 0x002C3365 File Offset: 0x002C1565
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerVoxelEnvResponse);
		}

		// Token: 0x06012F16 RID: 77590 RVA: 0x002C3373 File Offset: 0x002C1573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerVoxelEnvResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.VoxelEnv == other.VoxelEnv && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012F17 RID: 77591 RVA: 0x002C33B4 File Offset: 0x002C15B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.VoxelEnv != 0)
			{
				num ^= this.VoxelEnv.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012F18 RID: 77592 RVA: 0x002C3412 File Offset: 0x002C1612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012F19 RID: 77593 RVA: 0x002C341F File Offset: 0x002C161F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012F1A RID: 77594 RVA: 0x002C3428 File Offset: 0x002C1628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.VoxelEnv != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.VoxelEnv);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012F1B RID: 77595 RVA: 0x002C3484 File Offset: 0x002C1684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.VoxelEnv != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.VoxelEnv);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012F1C RID: 77596 RVA: 0x002C34DC File Offset: 0x002C16DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerVoxelEnvResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.VoxelEnv != 0)
			{
				this.VoxelEnv = other.VoxelEnv;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012F1D RID: 77597 RVA: 0x002C352C File Offset: 0x002C172C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012F1E RID: 77598 RVA: 0x002C3538 File Offset: 0x002C1738
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
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.VoxelEnv = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007528 RID: 29992
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007529 RID: 29993
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x0400752A RID: 29994
		private ErrorCode errorCode_;

		// Token: 0x0400752B RID: 29995
		public const int VoxelEnvFieldNumber = 15;

		// Token: 0x0400752C RID: 29996
		private int voxelEnv_;
	}
}
