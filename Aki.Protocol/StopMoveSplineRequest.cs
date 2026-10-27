using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001295 RID: 4757
	[NetMessage(EMessageId.StopMoveSplineRequest)]
	public sealed class StopMoveSplineRequest : IMessage<StopMoveSplineRequest>, IMessage, IEquatable<StopMoveSplineRequest>, IDeepCloneable<StopMoveSplineRequest>, IBufferMessage
	{
		// Token: 0x0601953C RID: 103740 RVA: 0x003AECE3 File Offset: 0x003ACEE3
		[NullableContext(1)]
		public static StopMoveSplineRequest Create()
		{
			return new StopMoveSplineRequest();
		}

		// Token: 0x1700556E RID: 21870
		// (get) Token: 0x0601953D RID: 103741 RVA: 0x003AECEA File Offset: 0x003ACEEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700556F RID: 21871
		// (get) Token: 0x0601953E RID: 103742 RVA: 0x003AECED File Offset: 0x003ACEED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StopMoveSplineRequest.Descriptor;
			}
		}

		// Token: 0x0601953F RID: 103743 RVA: 0x003AECF4 File Offset: 0x003ACEF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StopMoveSplineRequest()
		{
		}

		// Token: 0x06019540 RID: 103744 RVA: 0x003AECFC File Offset: 0x003ACEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StopMoveSplineRequest(StopMoveSplineRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.splineEntityId_ = other.splineEntityId_;
			this.isInterrupt_ = other.isInterrupt_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019541 RID: 103745 RVA: 0x003AED39 File Offset: 0x003ACF39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StopMoveSplineRequest Clone()
		{
			return new StopMoveSplineRequest(this);
		}

		// Token: 0x17005570 RID: 21872
		// (get) Token: 0x06019542 RID: 103746 RVA: 0x003AED41 File Offset: 0x003ACF41
		// (set) Token: 0x06019543 RID: 103747 RVA: 0x003AED49 File Offset: 0x003ACF49
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

		// Token: 0x17005571 RID: 21873
		// (get) Token: 0x06019544 RID: 103748 RVA: 0x003AED52 File Offset: 0x003ACF52
		// (set) Token: 0x06019545 RID: 103749 RVA: 0x003AED5A File Offset: 0x003ACF5A
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

		// Token: 0x17005572 RID: 21874
		// (get) Token: 0x06019546 RID: 103750 RVA: 0x003AED63 File Offset: 0x003ACF63
		// (set) Token: 0x06019547 RID: 103751 RVA: 0x003AED6B File Offset: 0x003ACF6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsInterrupt
		{
			get
			{
				return this.isInterrupt_;
			}
			set
			{
				this.isInterrupt_ = value;
			}
		}

		// Token: 0x06019548 RID: 103752 RVA: 0x003AED74 File Offset: 0x003ACF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StopMoveSplineRequest);
		}

		// Token: 0x06019549 RID: 103753 RVA: 0x003AED84 File Offset: 0x003ACF84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StopMoveSplineRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.SplineEntityId == other.SplineEntityId && this.IsInterrupt == other.IsInterrupt && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601954A RID: 103754 RVA: 0x003AEDE0 File Offset: 0x003ACFE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.SplineEntityId != 0)
			{
				num ^= this.SplineEntityId.GetHashCode();
			}
			if (this.IsInterrupt)
			{
				num ^= this.IsInterrupt.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601954B RID: 103755 RVA: 0x003AEE51 File Offset: 0x003AD051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601954C RID: 103756 RVA: 0x003AEE5E File Offset: 0x003AD05E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601954D RID: 103757 RVA: 0x003AEE68 File Offset: 0x003AD068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsInterrupt)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsInterrupt);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.EntityId);
			}
			if (this.SplineEntityId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.SplineEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601954E RID: 103758 RVA: 0x003AEEE0 File Offset: 0x003AD0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.SplineEntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SplineEntityId);
			}
			if (this.IsInterrupt)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601954F RID: 103759 RVA: 0x003AEF44 File Offset: 0x003AD144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StopMoveSplineRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.SplineEntityId != 0)
			{
				this.SplineEntityId = other.SplineEntityId;
			}
			if (other.IsInterrupt)
			{
				this.IsInterrupt = other.IsInterrupt;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019550 RID: 103760 RVA: 0x003AEFA8 File Offset: 0x003AD1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019551 RID: 103761 RVA: 0x003AEFB4 File Offset: 0x003AD1B4
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
				if (num != 32U)
				{
					if (num != 88U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SplineEntityId = input.ReadInt32();
						}
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.IsInterrupt = input.ReadBool();
				}
			}
		}

		// Token: 0x040094DA RID: 38106
		private UnknownFieldSet _unknownFields;

		// Token: 0x040094DB RID: 38107
		public const int EntityIdFieldNumber = 11;

		// Token: 0x040094DC RID: 38108
		private long entityId_;

		// Token: 0x040094DD RID: 38109
		public const int SplineEntityIdFieldNumber = 15;

		// Token: 0x040094DE RID: 38110
		private int splineEntityId_;

		// Token: 0x040094DF RID: 38111
		public const int IsInterruptFieldNumber = 4;

		// Token: 0x040094E0 RID: 38112
		private bool isInterrupt_;
	}
}
