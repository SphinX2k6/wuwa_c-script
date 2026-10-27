using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200116E RID: 4462
	public sealed class SceneItemPatrolInfoPb : IMessage<SceneItemPatrolInfoPb>, IMessage, IEquatable<SceneItemPatrolInfoPb>, IDeepCloneable<SceneItemPatrolInfoPb>, IBufferMessage
	{
		// Token: 0x06017C9F RID: 97439 RVA: 0x00374AA9 File Offset: 0x00372CA9
		[NullableContext(1)]
		public static SceneItemPatrolInfoPb Create()
		{
			return new SceneItemPatrolInfoPb();
		}

		// Token: 0x17004FEA RID: 20458
		// (get) Token: 0x06017CA0 RID: 97440 RVA: 0x00374AB0 File Offset: 0x00372CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004FEB RID: 20459
		// (get) Token: 0x06017CA1 RID: 97441 RVA: 0x00374AB3 File Offset: 0x00372CB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemPatrolInfoPb.Descriptor;
			}
		}

		// Token: 0x06017CA2 RID: 97442 RVA: 0x00374ABA File Offset: 0x00372CBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemPatrolInfoPb()
		{
		}

		// Token: 0x06017CA3 RID: 97443 RVA: 0x00374AC2 File Offset: 0x00372CC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemPatrolInfoPb(SceneItemPatrolInfoPb other) : this()
		{
			this.patrolPointIndex_ = other.patrolPointIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017CA4 RID: 97444 RVA: 0x00374AE7 File Offset: 0x00372CE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemPatrolInfoPb Clone()
		{
			return new SceneItemPatrolInfoPb(this);
		}

		// Token: 0x17004FEC RID: 20460
		// (get) Token: 0x06017CA5 RID: 97445 RVA: 0x00374AEF File Offset: 0x00372CEF
		// (set) Token: 0x06017CA6 RID: 97446 RVA: 0x00374AF7 File Offset: 0x00372CF7
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

		// Token: 0x06017CA7 RID: 97447 RVA: 0x00374B00 File Offset: 0x00372D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemPatrolInfoPb);
		}

		// Token: 0x06017CA8 RID: 97448 RVA: 0x00374B0E File Offset: 0x00372D0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemPatrolInfoPb other)
		{
			return other != null && (other == this || (this.PatrolPointIndex == other.PatrolPointIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017CA9 RID: 97449 RVA: 0x00374B3C File Offset: 0x00372D3C
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

		// Token: 0x06017CAA RID: 97450 RVA: 0x00374B7B File Offset: 0x00372D7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017CAB RID: 97451 RVA: 0x00374B88 File Offset: 0x00372D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017CAC RID: 97452 RVA: 0x00374B91 File Offset: 0x00372D91
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

		// Token: 0x06017CAD RID: 97453 RVA: 0x00374BC4 File Offset: 0x00372DC4
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

		// Token: 0x06017CAE RID: 97454 RVA: 0x00374C02 File Offset: 0x00372E02
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

		// Token: 0x06017CAF RID: 97455 RVA: 0x00374C33 File Offset: 0x00372E33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017CB0 RID: 97456 RVA: 0x00374C3C File Offset: 0x00372E3C
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

		// Token: 0x04008D1F RID: 36127
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D20 RID: 36128
		public const int PatrolPointIndexFieldNumber = 1;

		// Token: 0x04008D21 RID: 36129
		private int patrolPointIndex_;
	}
}
