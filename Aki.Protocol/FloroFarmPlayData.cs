using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000591 RID: 1425
	public sealed class FloroFarmPlayData : IMessage<FloroFarmPlayData>, IMessage, IEquatable<FloroFarmPlayData>, IDeepCloneable<FloroFarmPlayData>, IBufferMessage
	{
		// Token: 0x06008451 RID: 33873 RVA: 0x0013EB81 File Offset: 0x0013CD81
		[NullableContext(1)]
		public static FloroFarmPlayData Create()
		{
			return new FloroFarmPlayData();
		}

		// Token: 0x170019C6 RID: 6598
		// (get) Token: 0x06008452 RID: 33874 RVA: 0x0013EB88 File Offset: 0x0013CD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019C7 RID: 6599
		// (get) Token: 0x06008453 RID: 33875 RVA: 0x0013EB8B File Offset: 0x0013CD8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroFarmPlayData.Descriptor;
			}
		}

		// Token: 0x06008454 RID: 33876 RVA: 0x0013EB92 File Offset: 0x0013CD92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroFarmPlayData()
		{
		}

		// Token: 0x06008455 RID: 33877 RVA: 0x0013EB9A File Offset: 0x0013CD9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroFarmPlayData(FloroFarmPlayData other) : this()
		{
			this.hasRecord_ = other.hasRecord_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008456 RID: 33878 RVA: 0x0013EBBF File Offset: 0x0013CDBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroFarmPlayData Clone()
		{
			return new FloroFarmPlayData(this);
		}

		// Token: 0x170019C8 RID: 6600
		// (get) Token: 0x06008457 RID: 33879 RVA: 0x0013EBC7 File Offset: 0x0013CDC7
		// (set) Token: 0x06008458 RID: 33880 RVA: 0x0013EBCF File Offset: 0x0013CDCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasRecord
		{
			get
			{
				return this.hasRecord_;
			}
			set
			{
				this.hasRecord_ = value;
			}
		}

		// Token: 0x06008459 RID: 33881 RVA: 0x0013EBD8 File Offset: 0x0013CDD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroFarmPlayData);
		}

		// Token: 0x0600845A RID: 33882 RVA: 0x0013EBE6 File Offset: 0x0013CDE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroFarmPlayData other)
		{
			return other != null && (other == this || (this.HasRecord == other.HasRecord && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600845B RID: 33883 RVA: 0x0013EC14 File Offset: 0x0013CE14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HasRecord)
			{
				num ^= this.HasRecord.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600845C RID: 33884 RVA: 0x0013EC53 File Offset: 0x0013CE53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600845D RID: 33885 RVA: 0x0013EC60 File Offset: 0x0013CE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600845E RID: 33886 RVA: 0x0013EC69 File Offset: 0x0013CE69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasRecord)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.HasRecord);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600845F RID: 33887 RVA: 0x0013EC9C File Offset: 0x0013CE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HasRecord)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008460 RID: 33888 RVA: 0x0013ECCE File Offset: 0x0013CECE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroFarmPlayData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HasRecord)
			{
				this.HasRecord = other.HasRecord;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008461 RID: 33889 RVA: 0x0013ECFF File Offset: 0x0013CEFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008462 RID: 33890 RVA: 0x0013ED08 File Offset: 0x0013CF08
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
					this.HasRecord = input.ReadBool();
				}
			}
		}

		// Token: 0x0400420B RID: 16907
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400420C RID: 16908
		public const int HasRecordFieldNumber = 1;

		// Token: 0x0400420D RID: 16909
		private bool hasRecord_;
	}
}
