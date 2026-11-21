using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011A8 RID: 4520
	public sealed class SceneItemPatrolInfoPb : IMessage<SceneItemPatrolInfoPb>, IMessage, IEquatable<SceneItemPatrolInfoPb>, IDeepCloneable<SceneItemPatrolInfoPb>, IBufferMessage
	{
		// Token: 0x06018240 RID: 98880 RVA: 0x00383DF5 File Offset: 0x00381FF5
		[NullableContext(1)]
		public static SceneItemPatrolInfoPb Create()
		{
			return new SceneItemPatrolInfoPb();
		}

		// Token: 0x17005156 RID: 20822
		// (get) Token: 0x06018241 RID: 98881 RVA: 0x00383DFC File Offset: 0x00381FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005157 RID: 20823
		// (get) Token: 0x06018242 RID: 98882 RVA: 0x00383DFF File Offset: 0x00381FFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemPatrolInfoPb.Descriptor;
			}
		}

		// Token: 0x06018243 RID: 98883 RVA: 0x00383E06 File Offset: 0x00382006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemPatrolInfoPb()
		{
		}

		// Token: 0x06018244 RID: 98884 RVA: 0x00383E0E File Offset: 0x0038200E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemPatrolInfoPb(SceneItemPatrolInfoPb other) : this()
		{
			this.patrolPointIndex_ = other.patrolPointIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018245 RID: 98885 RVA: 0x00383E33 File Offset: 0x00382033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemPatrolInfoPb Clone()
		{
			return new SceneItemPatrolInfoPb(this);
		}

		// Token: 0x17005158 RID: 20824
		// (get) Token: 0x06018246 RID: 98886 RVA: 0x00383E3B File Offset: 0x0038203B
		// (set) Token: 0x06018247 RID: 98887 RVA: 0x00383E43 File Offset: 0x00382043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PatrolPointIndex
		{
			get
			{
				return this.patrolPointIndex_;
			}
			set
			{
				this.patrolPointIndex_ = value;
			}
		}

		// Token: 0x06018248 RID: 98888 RVA: 0x00383E4C File Offset: 0x0038204C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemPatrolInfoPb);
		}

		// Token: 0x06018249 RID: 98889 RVA: 0x00383E5A File Offset: 0x0038205A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemPatrolInfoPb other)
		{
			return other != null && (other == this || (this.PatrolPointIndex == other.PatrolPointIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601824A RID: 98890 RVA: 0x00383E88 File Offset: 0x00382088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PatrolPointIndex != 0)
			{
				num ^= this.PatrolPointIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601824B RID: 98891 RVA: 0x00383EC7 File Offset: 0x003820C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601824C RID: 98892 RVA: 0x00383ED4 File Offset: 0x003820D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601824D RID: 98893 RVA: 0x00383EDD File Offset: 0x003820DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PatrolPointIndex != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PatrolPointIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601824E RID: 98894 RVA: 0x00383F10 File Offset: 0x00382110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PatrolPointIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PatrolPointIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601824F RID: 98895 RVA: 0x00383F4E File Offset: 0x0038214E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemPatrolInfoPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PatrolPointIndex != 0)
			{
				this.PatrolPointIndex = other.PatrolPointIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018250 RID: 98896 RVA: 0x00383F7F File Offset: 0x0038217F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018251 RID: 98897 RVA: 0x00383F88 File Offset: 0x00382188
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
					this.PatrolPointIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008FB2 RID: 36786
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FB3 RID: 36787
		public const int PatrolPointIndexFieldNumber = 1;

		// Token: 0x04008FB4 RID: 36788
		private int patrolPointIndex_;
	}
}
