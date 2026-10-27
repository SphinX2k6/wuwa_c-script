using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DBB RID: 3515
	[NetMessage(EMessageId.PlayerVoxelEnvRequest)]
	public sealed class PlayerVoxelEnvRequest : IMessage<PlayerVoxelEnvRequest>, IMessage, IEquatable<PlayerVoxelEnvRequest>, IDeepCloneable<PlayerVoxelEnvRequest>, IBufferMessage
	{
		// Token: 0x06012EF9 RID: 77561 RVA: 0x002C3118 File Offset: 0x002C1318
		[NullableContext(1)]
		public static PlayerVoxelEnvRequest Create()
		{
			return new PlayerVoxelEnvRequest();
		}

		// Token: 0x17003EDC RID: 16092
		// (get) Token: 0x06012EFA RID: 77562 RVA: 0x002C311F File Offset: 0x002C131F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EDD RID: 16093
		// (get) Token: 0x06012EFB RID: 77563 RVA: 0x002C3122 File Offset: 0x002C1322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerVoxelEnvRequest.Descriptor;
			}
		}

		// Token: 0x06012EFC RID: 77564 RVA: 0x002C3129 File Offset: 0x002C1329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerVoxelEnvRequest()
		{
		}

		// Token: 0x06012EFD RID: 77565 RVA: 0x002C3131 File Offset: 0x002C1331
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerVoxelEnvRequest(PlayerVoxelEnvRequest other) : this()
		{
			this.voxelEnv_ = other.voxelEnv_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012EFE RID: 77566 RVA: 0x002C3156 File Offset: 0x002C1356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerVoxelEnvRequest Clone()
		{
			return new PlayerVoxelEnvRequest(this);
		}

		// Token: 0x17003EDE RID: 16094
		// (get) Token: 0x06012EFF RID: 77567 RVA: 0x002C315E File Offset: 0x002C135E
		// (set) Token: 0x06012F00 RID: 77568 RVA: 0x002C3166 File Offset: 0x002C1366
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

		// Token: 0x06012F01 RID: 77569 RVA: 0x002C316F File Offset: 0x002C136F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerVoxelEnvRequest);
		}

		// Token: 0x06012F02 RID: 77570 RVA: 0x002C317D File Offset: 0x002C137D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerVoxelEnvRequest other)
		{
			return other != null && (other == this || (this.VoxelEnv == other.VoxelEnv && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012F03 RID: 77571 RVA: 0x002C31AC File Offset: 0x002C13AC
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

		// Token: 0x06012F04 RID: 77572 RVA: 0x002C31EB File Offset: 0x002C13EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012F05 RID: 77573 RVA: 0x002C31F8 File Offset: 0x002C13F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012F06 RID: 77574 RVA: 0x002C3201 File Offset: 0x002C1401
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.VoxelEnv != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.VoxelEnv);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012F07 RID: 77575 RVA: 0x002C3234 File Offset: 0x002C1434
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

		// Token: 0x06012F08 RID: 77576 RVA: 0x002C3272 File Offset: 0x002C1472
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

		// Token: 0x06012F09 RID: 77577 RVA: 0x002C32A3 File Offset: 0x002C14A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012F0A RID: 77578 RVA: 0x002C32AC File Offset: 0x002C14AC
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.VoxelEnv = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007525 RID: 29989
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007526 RID: 29990
		public const int VoxelEnvFieldNumber = 13;

		// Token: 0x04007527 RID: 29991
		private int voxelEnv_;
	}
}
