using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B64 RID: 2916
	public sealed class NpcPb : IMessage<NpcPb>, IMessage, IEquatable<NpcPb>, IDeepCloneable<NpcPb>, IBufferMessage
	{
		// Token: 0x0600FCA2 RID: 64674 RVA: 0x0024C868 File Offset: 0x0024AA68
		[NullableContext(1)]
		public static NpcPb Create()
		{
			return new NpcPb();
		}

		// Token: 0x1700337E RID: 13182
		// (get) Token: 0x0600FCA3 RID: 64675 RVA: 0x0024C86F File Offset: 0x0024AA6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700337F RID: 13183
		// (get) Token: 0x0600FCA4 RID: 64676 RVA: 0x0024C872 File Offset: 0x0024AA72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPb.Descriptor;
			}
		}

		// Token: 0x0600FCA5 RID: 64677 RVA: 0x0024C879 File Offset: 0x0024AA79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPb()
		{
		}

		// Token: 0x0600FCA6 RID: 64678 RVA: 0x0024C881 File Offset: 0x0024AA81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPb(NpcPb other) : this()
		{
			this.splineEntityId_ = other.splineEntityId_;
			this.spawnEntityId_ = other.spawnEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FCA7 RID: 64679 RVA: 0x0024C8B2 File Offset: 0x0024AAB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPb Clone()
		{
			return new NpcPb(this);
		}

		// Token: 0x17003380 RID: 13184
		// (get) Token: 0x0600FCA8 RID: 64680 RVA: 0x0024C8BA File Offset: 0x0024AABA
		// (set) Token: 0x0600FCA9 RID: 64681 RVA: 0x0024C8C2 File Offset: 0x0024AAC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SplineEntityId
		{
			get
			{
				return this.splineEntityId_;
			}
			set
			{
				this.splineEntityId_ = value;
			}
		}

		// Token: 0x17003381 RID: 13185
		// (get) Token: 0x0600FCAA RID: 64682 RVA: 0x0024C8CB File Offset: 0x0024AACB
		// (set) Token: 0x0600FCAB RID: 64683 RVA: 0x0024C8D3 File Offset: 0x0024AAD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SpawnEntityId
		{
			get
			{
				return this.spawnEntityId_;
			}
			set
			{
				this.spawnEntityId_ = value;
			}
		}

		// Token: 0x0600FCAC RID: 64684 RVA: 0x0024C8DC File Offset: 0x0024AADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPb);
		}

		// Token: 0x0600FCAD RID: 64685 RVA: 0x0024C8EA File Offset: 0x0024AAEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPb other)
		{
			return other != null && (other == this || (this.SplineEntityId == other.SplineEntityId && this.SpawnEntityId == other.SpawnEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FCAE RID: 64686 RVA: 0x0024C928 File Offset: 0x0024AB28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SplineEntityId != 0)
			{
				num ^= this.SplineEntityId.GetHashCode();
			}
			if (this.SpawnEntityId != 0)
			{
				num ^= this.SpawnEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FCAF RID: 64687 RVA: 0x0024C980 File Offset: 0x0024AB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FCB0 RID: 64688 RVA: 0x0024C98D File Offset: 0x0024AB8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FCB1 RID: 64689 RVA: 0x0024C998 File Offset: 0x0024AB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SplineEntityId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SplineEntityId);
			}
			if (this.SpawnEntityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SpawnEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FCB2 RID: 64690 RVA: 0x0024C9F4 File Offset: 0x0024ABF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SplineEntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SplineEntityId);
			}
			if (this.SpawnEntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SpawnEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FCB3 RID: 64691 RVA: 0x0024CA4C File Offset: 0x0024AC4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SplineEntityId != 0)
			{
				this.SplineEntityId = other.SplineEntityId;
			}
			if (other.SpawnEntityId != 0)
			{
				this.SpawnEntityId = other.SpawnEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FCB4 RID: 64692 RVA: 0x0024CA9C File Offset: 0x0024AC9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FCB5 RID: 64693 RVA: 0x0024CAA8 File Offset: 0x0024ACA8
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
				if (num != 16U)
				{
					if (num != 24U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SpawnEntityId = input.ReadInt32();
					}
				}
				else
				{
					this.SplineEntityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040064CF RID: 25807
		private UnknownFieldSet _unknownFields;

		// Token: 0x040064D0 RID: 25808
		public const int SplineEntityIdFieldNumber = 2;

		// Token: 0x040064D1 RID: 25809
		private int splineEntityId_;

		// Token: 0x040064D2 RID: 25810
		public const int SpawnEntityIdFieldNumber = 3;

		// Token: 0x040064D3 RID: 25811
		private int spawnEntityId_;
	}
}
