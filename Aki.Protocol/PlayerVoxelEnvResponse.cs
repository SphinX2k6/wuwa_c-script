using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DAC RID: 3500
	[NetMessage(EMessageId.PlayerVoxelEnvResponse)]
	public sealed class PlayerVoxelEnvResponse : IMessage<PlayerVoxelEnvResponse>, IMessage, IEquatable<PlayerVoxelEnvResponse>, IDeepCloneable<PlayerVoxelEnvResponse>, IBufferMessage
	{
		// Token: 0x06012E0F RID: 77327 RVA: 0x002C16CD File Offset: 0x002BF8CD
		[NullableContext(1)]
		public static PlayerVoxelEnvResponse Create()
		{
			return new PlayerVoxelEnvResponse();
		}

		// Token: 0x17003EAA RID: 16042
		// (get) Token: 0x06012E10 RID: 77328 RVA: 0x002C16D4 File Offset: 0x002BF8D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EAB RID: 16043
		// (get) Token: 0x06012E11 RID: 77329 RVA: 0x002C16D7 File Offset: 0x002BF8D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerVoxelEnvResponse.Descriptor;
			}
		}

		// Token: 0x06012E12 RID: 77330 RVA: 0x002C16DE File Offset: 0x002BF8DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerVoxelEnvResponse()
		{
		}

		// Token: 0x06012E13 RID: 77331 RVA: 0x002C16E6 File Offset: 0x002BF8E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerVoxelEnvResponse(PlayerVoxelEnvResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.voxelEnv_ = other.voxelEnv_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012E14 RID: 77332 RVA: 0x002C1717 File Offset: 0x002BF917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerVoxelEnvResponse Clone()
		{
			return new PlayerVoxelEnvResponse(this);
		}

		// Token: 0x17003EAC RID: 16044
		// (get) Token: 0x06012E15 RID: 77333 RVA: 0x002C171F File Offset: 0x002BF91F
		// (set) Token: 0x06012E16 RID: 77334 RVA: 0x002C1727 File Offset: 0x002BF927
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

		// Token: 0x17003EAD RID: 16045
		// (get) Token: 0x06012E17 RID: 77335 RVA: 0x002C1730 File Offset: 0x002BF930
		// (set) Token: 0x06012E18 RID: 77336 RVA: 0x002C1738 File Offset: 0x002BF938
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

		// Token: 0x06012E19 RID: 77337 RVA: 0x002C1741 File Offset: 0x002BF941
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerVoxelEnvResponse);
		}

		// Token: 0x06012E1A RID: 77338 RVA: 0x002C174F File Offset: 0x002BF94F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerVoxelEnvResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.VoxelEnv == other.VoxelEnv && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012E1B RID: 77339 RVA: 0x002C1790 File Offset: 0x002BF990
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

		// Token: 0x06012E1C RID: 77340 RVA: 0x002C17EE File Offset: 0x002BF9EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012E1D RID: 77341 RVA: 0x002C17FB File Offset: 0x002BF9FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012E1E RID: 77342 RVA: 0x002C1804 File Offset: 0x002BFA04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.VoxelEnv != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.VoxelEnv);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012E1F RID: 77343 RVA: 0x002C1860 File Offset: 0x002BFA60
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

		// Token: 0x06012E20 RID: 77344 RVA: 0x002C18B8 File Offset: 0x002BFAB8
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

		// Token: 0x06012E21 RID: 77345 RVA: 0x002C1908 File Offset: 0x002BFB08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012E22 RID: 77346 RVA: 0x002C1914 File Offset: 0x002BFB14
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
					if (num != 48U)
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

		// Token: 0x04007540 RID: 30016
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007541 RID: 30017
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04007542 RID: 30018
		private ErrorCode errorCode_;

		// Token: 0x04007543 RID: 30019
		public const int VoxelEnvFieldNumber = 6;

		// Token: 0x04007544 RID: 30020
		private int voxelEnv_;
	}
}
