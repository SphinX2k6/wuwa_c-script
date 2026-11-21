using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DAB RID: 3499
	[NetMessage(EMessageId.PlayerVoxelEnvRequest)]
	public sealed class PlayerVoxelEnvRequest : IMessage<PlayerVoxelEnvRequest>, IMessage, IEquatable<PlayerVoxelEnvRequest>, IDeepCloneable<PlayerVoxelEnvRequest>, IBufferMessage
	{
		// Token: 0x06012DFD RID: 77309 RVA: 0x002C14F4 File Offset: 0x002BF6F4
		[NullableContext(1)]
		public static PlayerVoxelEnvRequest Create()
		{
			return new PlayerVoxelEnvRequest();
		}

		// Token: 0x17003EA7 RID: 16039
		// (get) Token: 0x06012DFE RID: 77310 RVA: 0x002C14FB File Offset: 0x002BF6FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EA8 RID: 16040
		// (get) Token: 0x06012DFF RID: 77311 RVA: 0x002C14FE File Offset: 0x002BF6FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerVoxelEnvRequest.Descriptor;
			}
		}

		// Token: 0x06012E00 RID: 77312 RVA: 0x002C1505 File Offset: 0x002BF705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerVoxelEnvRequest()
		{
		}

		// Token: 0x06012E01 RID: 77313 RVA: 0x002C150D File Offset: 0x002BF70D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerVoxelEnvRequest(PlayerVoxelEnvRequest other) : this()
		{
			this.voxelEnv_ = other.voxelEnv_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012E02 RID: 77314 RVA: 0x002C1532 File Offset: 0x002BF732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerVoxelEnvRequest Clone()
		{
			return new PlayerVoxelEnvRequest(this);
		}

		// Token: 0x17003EA9 RID: 16041
		// (get) Token: 0x06012E03 RID: 77315 RVA: 0x002C153A File Offset: 0x002BF73A
		// (set) Token: 0x06012E04 RID: 77316 RVA: 0x002C1542 File Offset: 0x002BF742
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

		// Token: 0x06012E05 RID: 77317 RVA: 0x002C154B File Offset: 0x002BF74B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerVoxelEnvRequest);
		}

		// Token: 0x06012E06 RID: 77318 RVA: 0x002C1559 File Offset: 0x002BF759
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerVoxelEnvRequest other)
		{
			return other != null && (other == this || (this.VoxelEnv == other.VoxelEnv && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012E07 RID: 77319 RVA: 0x002C1588 File Offset: 0x002BF788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06012E08 RID: 77320 RVA: 0x002C15C7 File Offset: 0x002BF7C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012E09 RID: 77321 RVA: 0x002C15D4 File Offset: 0x002BF7D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012E0A RID: 77322 RVA: 0x002C15DD File Offset: 0x002BF7DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.VoxelEnv != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.VoxelEnv);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012E0B RID: 77323 RVA: 0x002C1610 File Offset: 0x002BF810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06012E0C RID: 77324 RVA: 0x002C164E File Offset: 0x002BF84E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerVoxelEnvRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.VoxelEnv != 0)
			{
				this.VoxelEnv = other.VoxelEnv;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012E0D RID: 77325 RVA: 0x002C167F File Offset: 0x002BF87F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012E0E RID: 77326 RVA: 0x002C1688 File Offset: 0x002BF888
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.VoxelEnv = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400753D RID: 30013
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400753E RID: 30014
		public const int VoxelEnvFieldNumber = 10;

		// Token: 0x0400753F RID: 30015
		private int voxelEnv_;
	}
}
