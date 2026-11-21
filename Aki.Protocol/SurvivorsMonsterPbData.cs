using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001341 RID: 4929
	public sealed class SurvivorsMonsterPbData : IMessage<SurvivorsMonsterPbData>, IMessage, IEquatable<SurvivorsMonsterPbData>, IDeepCloneable<SurvivorsMonsterPbData>, IBufferMessage
	{
		// Token: 0x0601A453 RID: 107603 RVA: 0x003D4500 File Offset: 0x003D2700
		[NullableContext(1)]
		public static SurvivorsMonsterPbData Create()
		{
			return new SurvivorsMonsterPbData();
		}

		// Token: 0x170058F9 RID: 22777
		// (get) Token: 0x0601A454 RID: 107604 RVA: 0x003D4507 File Offset: 0x003D2707
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058FA RID: 22778
		// (get) Token: 0x0601A455 RID: 107605 RVA: 0x003D450A File Offset: 0x003D270A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsMonsterPbData.Descriptor;
			}
		}

		// Token: 0x0601A456 RID: 107606 RVA: 0x003D4511 File Offset: 0x003D2711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsMonsterPbData()
		{
		}

		// Token: 0x0601A457 RID: 107607 RVA: 0x003D4519 File Offset: 0x003D2719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsMonsterPbData(SurvivorsMonsterPbData other) : this()
		{
			this.spawnPointEntityId_ = other.spawnPointEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A458 RID: 107608 RVA: 0x003D453E File Offset: 0x003D273E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsMonsterPbData Clone()
		{
			return new SurvivorsMonsterPbData(this);
		}

		// Token: 0x170058FB RID: 22779
		// (get) Token: 0x0601A459 RID: 107609 RVA: 0x003D4546 File Offset: 0x003D2746
		// (set) Token: 0x0601A45A RID: 107610 RVA: 0x003D454E File Offset: 0x003D274E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SpawnPointEntityId
		{
			get
			{
				return this.spawnPointEntityId_;
			}
			set
			{
				this.spawnPointEntityId_ = value;
			}
		}

		// Token: 0x0601A45B RID: 107611 RVA: 0x003D4557 File Offset: 0x003D2757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsMonsterPbData);
		}

		// Token: 0x0601A45C RID: 107612 RVA: 0x003D4565 File Offset: 0x003D2765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsMonsterPbData other)
		{
			return other != null && (other == this || (this.SpawnPointEntityId == other.SpawnPointEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A45D RID: 107613 RVA: 0x003D4594 File Offset: 0x003D2794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SpawnPointEntityId != 0)
			{
				num ^= this.SpawnPointEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A45E RID: 107614 RVA: 0x003D45D3 File Offset: 0x003D27D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A45F RID: 107615 RVA: 0x003D45E0 File Offset: 0x003D27E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A460 RID: 107616 RVA: 0x003D45E9 File Offset: 0x003D27E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SpawnPointEntityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SpawnPointEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A461 RID: 107617 RVA: 0x003D461C File Offset: 0x003D281C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SpawnPointEntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SpawnPointEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A462 RID: 107618 RVA: 0x003D465A File Offset: 0x003D285A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsMonsterPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SpawnPointEntityId != 0)
			{
				this.SpawnPointEntityId = other.SpawnPointEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A463 RID: 107619 RVA: 0x003D468B File Offset: 0x003D288B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A464 RID: 107620 RVA: 0x003D4694 File Offset: 0x003D2894
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
					this.SpawnPointEntityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009A78 RID: 39544
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A79 RID: 39545
		public const int SpawnPointEntityIdFieldNumber = 1;

		// Token: 0x04009A7A RID: 39546
		private int spawnPointEntityId_;
	}
}
