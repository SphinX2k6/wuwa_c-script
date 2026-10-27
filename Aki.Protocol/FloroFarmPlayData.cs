using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005A6 RID: 1446
	public sealed class FloroFarmPlayData : IMessage<FloroFarmPlayData>, IMessage, IEquatable<FloroFarmPlayData>, IDeepCloneable<FloroFarmPlayData>, IBufferMessage
	{
		// Token: 0x060085B9 RID: 34233 RVA: 0x00141789 File Offset: 0x0013F989
		[NullableContext(1)]
		public static FloroFarmPlayData Create()
		{
			return new FloroFarmPlayData();
		}

		// Token: 0x17001A13 RID: 6675
		// (get) Token: 0x060085BA RID: 34234 RVA: 0x00141790 File Offset: 0x0013F990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A14 RID: 6676
		// (get) Token: 0x060085BB RID: 34235 RVA: 0x00141793 File Offset: 0x0013F993
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroFarmPlayData.Descriptor;
			}
		}

		// Token: 0x060085BC RID: 34236 RVA: 0x0014179A File Offset: 0x0013F99A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroFarmPlayData()
		{
		}

		// Token: 0x060085BD RID: 34237 RVA: 0x001417A2 File Offset: 0x0013F9A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroFarmPlayData(FloroFarmPlayData other) : this()
		{
			this.hasRecord_ = other.hasRecord_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060085BE RID: 34238 RVA: 0x001417C7 File Offset: 0x0013F9C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroFarmPlayData Clone()
		{
			return new FloroFarmPlayData(this);
		}

		// Token: 0x17001A15 RID: 6677
		// (get) Token: 0x060085BF RID: 34239 RVA: 0x001417CF File Offset: 0x0013F9CF
		// (set) Token: 0x060085C0 RID: 34240 RVA: 0x001417D7 File Offset: 0x0013F9D7
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

		// Token: 0x060085C1 RID: 34241 RVA: 0x001417E0 File Offset: 0x0013F9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroFarmPlayData);
		}

		// Token: 0x060085C2 RID: 34242 RVA: 0x001417EE File Offset: 0x0013F9EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroFarmPlayData other)
		{
			return other != null && (other == this || (this.HasRecord == other.HasRecord && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060085C3 RID: 34243 RVA: 0x0014181C File Offset: 0x0013FA1C
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

		// Token: 0x060085C4 RID: 34244 RVA: 0x0014185B File Offset: 0x0013FA5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060085C5 RID: 34245 RVA: 0x00141868 File Offset: 0x0013FA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060085C6 RID: 34246 RVA: 0x00141871 File Offset: 0x0013FA71
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

		// Token: 0x060085C7 RID: 34247 RVA: 0x001418A4 File Offset: 0x0013FAA4
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

		// Token: 0x060085C8 RID: 34248 RVA: 0x001418D6 File Offset: 0x0013FAD6
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

		// Token: 0x060085C9 RID: 34249 RVA: 0x00141907 File Offset: 0x0013FB07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060085CA RID: 34250 RVA: 0x00141910 File Offset: 0x0013FB10
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

		// Token: 0x04004215 RID: 16917
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004216 RID: 16918
		public const int HasRecordFieldNumber = 1;

		// Token: 0x04004217 RID: 16919
		private bool hasRecord_;
	}
}
