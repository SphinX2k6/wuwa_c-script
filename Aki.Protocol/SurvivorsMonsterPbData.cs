using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012D2 RID: 4818
	public sealed class SurvivorsMonsterPbData : IMessage<SurvivorsMonsterPbData>, IMessage, IEquatable<SurvivorsMonsterPbData>, IDeepCloneable<SurvivorsMonsterPbData>, IBufferMessage
	{
		// Token: 0x06019A1D RID: 104989 RVA: 0x003B9DCC File Offset: 0x003B7FCC
		[NullableContext(1)]
		public static SurvivorsMonsterPbData Create()
		{
			return new SurvivorsMonsterPbData();
		}

		// Token: 0x17005678 RID: 22136
		// (get) Token: 0x06019A1E RID: 104990 RVA: 0x003B9DD3 File Offset: 0x003B7FD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005679 RID: 22137
		// (get) Token: 0x06019A1F RID: 104991 RVA: 0x003B9DD6 File Offset: 0x003B7FD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsMonsterPbData.Descriptor;
			}
		}

		// Token: 0x06019A20 RID: 104992 RVA: 0x003B9DDD File Offset: 0x003B7FDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsMonsterPbData()
		{
		}

		// Token: 0x06019A21 RID: 104993 RVA: 0x003B9DE5 File Offset: 0x003B7FE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsMonsterPbData(SurvivorsMonsterPbData other) : this()
		{
			this.spawnPointEntityId_ = other.spawnPointEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019A22 RID: 104994 RVA: 0x003B9E0A File Offset: 0x003B800A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsMonsterPbData Clone()
		{
			return new SurvivorsMonsterPbData(this);
		}

		// Token: 0x1700567A RID: 22138
		// (get) Token: 0x06019A23 RID: 104995 RVA: 0x003B9E12 File Offset: 0x003B8012
		// (set) Token: 0x06019A24 RID: 104996 RVA: 0x003B9E1A File Offset: 0x003B801A
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

		// Token: 0x06019A25 RID: 104997 RVA: 0x003B9E23 File Offset: 0x003B8023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsMonsterPbData);
		}

		// Token: 0x06019A26 RID: 104998 RVA: 0x003B9E31 File Offset: 0x003B8031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsMonsterPbData other)
		{
			return other != null && (other == this || (this.SpawnPointEntityId == other.SpawnPointEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019A27 RID: 104999 RVA: 0x003B9E60 File Offset: 0x003B8060
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

		// Token: 0x06019A28 RID: 105000 RVA: 0x003B9E9F File Offset: 0x003B809F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019A29 RID: 105001 RVA: 0x003B9EAC File Offset: 0x003B80AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019A2A RID: 105002 RVA: 0x003B9EB5 File Offset: 0x003B80B5
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

		// Token: 0x06019A2B RID: 105003 RVA: 0x003B9EE8 File Offset: 0x003B80E8
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

		// Token: 0x06019A2C RID: 105004 RVA: 0x003B9F26 File Offset: 0x003B8126
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

		// Token: 0x06019A2D RID: 105005 RVA: 0x003B9F57 File Offset: 0x003B8157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019A2E RID: 105006 RVA: 0x003B9F60 File Offset: 0x003B8160
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

		// Token: 0x0400964E RID: 38478
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400964F RID: 38479
		public const int SpawnPointEntityIdFieldNumber = 1;

		// Token: 0x04009650 RID: 38480
		private int spawnPointEntityId_;
	}
}
