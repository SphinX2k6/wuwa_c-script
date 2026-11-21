using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011B1 RID: 4529
	[NetMessage(EMessageId.SceneItemStateRequest)]
	public sealed class SceneItemStateRequest : IMessage<SceneItemStateRequest>, IMessage, IEquatable<SceneItemStateRequest>, IDeepCloneable<SceneItemStateRequest>, IBufferMessage
	{
		// Token: 0x060182F8 RID: 99064 RVA: 0x00385738 File Offset: 0x00383938
		[NullableContext(1)]
		public static SceneItemStateRequest Create()
		{
			return new SceneItemStateRequest();
		}

		// Token: 0x1700517C RID: 20860
		// (get) Token: 0x060182F9 RID: 99065 RVA: 0x0038573F File Offset: 0x0038393F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700517D RID: 20861
		// (get) Token: 0x060182FA RID: 99066 RVA: 0x00385742 File Offset: 0x00383942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemStateRequest.Descriptor;
			}
		}

		// Token: 0x060182FB RID: 99067 RVA: 0x00385749 File Offset: 0x00383949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemStateRequest()
		{
		}

		// Token: 0x060182FC RID: 99068 RVA: 0x00385751 File Offset: 0x00383951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemStateRequest(SceneItemStateRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.operateType_ = other.operateType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060182FD RID: 99069 RVA: 0x00385782 File Offset: 0x00383982
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemStateRequest Clone()
		{
			return new SceneItemStateRequest(this);
		}

		// Token: 0x1700517E RID: 20862
		// (get) Token: 0x060182FE RID: 99070 RVA: 0x0038578A File Offset: 0x0038398A
		// (set) Token: 0x060182FF RID: 99071 RVA: 0x00385792 File Offset: 0x00383992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x1700517F RID: 20863
		// (get) Token: 0x06018300 RID: 99072 RVA: 0x0038579B File Offset: 0x0038399B
		// (set) Token: 0x06018301 RID: 99073 RVA: 0x003857A3 File Offset: 0x003839A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OperateType
		{
			get
			{
				return this.operateType_;
			}
			set
			{
				this.operateType_ = value;
			}
		}

		// Token: 0x06018302 RID: 99074 RVA: 0x003857AC File Offset: 0x003839AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemStateRequest);
		}

		// Token: 0x06018303 RID: 99075 RVA: 0x003857BA File Offset: 0x003839BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemStateRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.OperateType == other.OperateType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018304 RID: 99076 RVA: 0x003857F8 File Offset: 0x003839F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.OperateType != 0)
			{
				num ^= this.OperateType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018305 RID: 99077 RVA: 0x00385850 File Offset: 0x00383A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018306 RID: 99078 RVA: 0x0038585D File Offset: 0x00383A5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018307 RID: 99079 RVA: 0x00385868 File Offset: 0x00383A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityId);
			}
			if (this.OperateType != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.OperateType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018308 RID: 99080 RVA: 0x003858C4 File Offset: 0x00383AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.OperateType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OperateType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018309 RID: 99081 RVA: 0x0038591C File Offset: 0x00383B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemStateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.OperateType != 0)
			{
				this.OperateType = other.OperateType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601830A RID: 99082 RVA: 0x0038596C File Offset: 0x00383B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601830B RID: 99083 RVA: 0x00385978 File Offset: 0x00383B78
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
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.OperateType = input.ReadInt32();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04008FE3 RID: 36835
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FE4 RID: 36836
		public const int EntityIdFieldNumber = 5;

		// Token: 0x04008FE5 RID: 36837
		private long entityId_;

		// Token: 0x04008FE6 RID: 36838
		public const int OperateTypeFieldNumber = 10;

		// Token: 0x04008FE7 RID: 36839
		private int operateType_;
	}
}
