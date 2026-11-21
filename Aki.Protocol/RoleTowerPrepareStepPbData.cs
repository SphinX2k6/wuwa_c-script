using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010D6 RID: 4310
	public sealed class RoleTowerPrepareStepPbData : IMessage<RoleTowerPrepareStepPbData>, IMessage, IEquatable<RoleTowerPrepareStepPbData>, IDeepCloneable<RoleTowerPrepareStepPbData>, IBufferMessage
	{
		// Token: 0x060170A6 RID: 94374 RVA: 0x0035A1BB File Offset: 0x003583BB
		[NullableContext(1)]
		public static RoleTowerPrepareStepPbData Create()
		{
			return new RoleTowerPrepareStepPbData();
		}

		// Token: 0x17004D55 RID: 19797
		// (get) Token: 0x060170A7 RID: 94375 RVA: 0x0035A1C2 File Offset: 0x003583C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D56 RID: 19798
		// (get) Token: 0x060170A8 RID: 94376 RVA: 0x0035A1C5 File Offset: 0x003583C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerPrepareStepPbData.Descriptor;
			}
		}

		// Token: 0x060170A9 RID: 94377 RVA: 0x0035A1CC File Offset: 0x003583CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerPrepareStepPbData()
		{
		}

		// Token: 0x060170AA RID: 94378 RVA: 0x0035A1D4 File Offset: 0x003583D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerPrepareStepPbData(RoleTowerPrepareStepPbData other) : this()
		{
			this.prepareInfo_ = ((other.prepareInfo_ != null) ? other.prepareInfo_.Clone() : null);
			this.prepareSelection_ = ((other.prepareSelection_ != null) ? other.prepareSelection_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060170AB RID: 94379 RVA: 0x0035A230 File Offset: 0x00358430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerPrepareStepPbData Clone()
		{
			return new RoleTowerPrepareStepPbData(this);
		}

		// Token: 0x17004D57 RID: 19799
		// (get) Token: 0x060170AC RID: 94380 RVA: 0x0035A238 File Offset: 0x00358438
		// (set) Token: 0x060170AD RID: 94381 RVA: 0x0035A240 File Offset: 0x00358440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerPrepareInfo PrepareInfo
		{
			get
			{
				return this.prepareInfo_;
			}
			set
			{
				this.prepareInfo_ = value;
			}
		}

		// Token: 0x17004D58 RID: 19800
		// (get) Token: 0x060170AE RID: 94382 RVA: 0x0035A249 File Offset: 0x00358449
		// (set) Token: 0x060170AF RID: 94383 RVA: 0x0035A251 File Offset: 0x00358451
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerPrepareSelection PrepareSelection
		{
			get
			{
				return this.prepareSelection_;
			}
			set
			{
				this.prepareSelection_ = value;
			}
		}

		// Token: 0x060170B0 RID: 94384 RVA: 0x0035A25A File Offset: 0x0035845A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerPrepareStepPbData);
		}

		// Token: 0x060170B1 RID: 94385 RVA: 0x0035A268 File Offset: 0x00358468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerPrepareStepPbData other)
		{
			return other != null && (other == this || (object.Equals(this.PrepareInfo, other.PrepareInfo) && object.Equals(this.PrepareSelection, other.PrepareSelection) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060170B2 RID: 94386 RVA: 0x0035A2BC File Offset: 0x003584BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.prepareInfo_ != null)
			{
				num ^= this.PrepareInfo.GetHashCode();
			}
			if (this.prepareSelection_ != null)
			{
				num ^= this.PrepareSelection.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060170B3 RID: 94387 RVA: 0x0035A30E File Offset: 0x0035850E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060170B4 RID: 94388 RVA: 0x0035A31B File Offset: 0x0035851B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060170B5 RID: 94389 RVA: 0x0035A324 File Offset: 0x00358524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.prepareInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.PrepareInfo);
			}
			if (this.prepareSelection_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.PrepareSelection);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060170B6 RID: 94390 RVA: 0x0035A380 File Offset: 0x00358580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.prepareInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PrepareInfo);
			}
			if (this.prepareSelection_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PrepareSelection);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060170B7 RID: 94391 RVA: 0x0035A3D8 File Offset: 0x003585D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerPrepareStepPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.prepareInfo_ != null)
			{
				if (this.prepareInfo_ == null)
				{
					this.PrepareInfo = new RoleTowerPrepareInfo();
				}
				this.PrepareInfo.MergeFrom(other.PrepareInfo);
			}
			if (other.prepareSelection_ != null)
			{
				if (this.prepareSelection_ == null)
				{
					this.PrepareSelection = new RoleTowerPrepareSelection();
				}
				this.PrepareSelection.MergeFrom(other.PrepareSelection);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060170B8 RID: 94392 RVA: 0x0035A458 File Offset: 0x00358658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060170B9 RID: 94393 RVA: 0x0035A464 File Offset: 0x00358664
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
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.prepareSelection_ == null)
						{
							this.PrepareSelection = new RoleTowerPrepareSelection();
						}
						input.ReadMessage(this.PrepareSelection);
					}
				}
				else
				{
					if (this.prepareInfo_ == null)
					{
						this.PrepareInfo = new RoleTowerPrepareInfo();
					}
					input.ReadMessage(this.PrepareInfo);
				}
			}
		}

		// Token: 0x040089F0 RID: 35312
		private UnknownFieldSet _unknownFields;

		// Token: 0x040089F1 RID: 35313
		public const int PrepareInfoFieldNumber = 1;

		// Token: 0x040089F2 RID: 35314
		private RoleTowerPrepareInfo prepareInfo_;

		// Token: 0x040089F3 RID: 35315
		public const int PrepareSelectionFieldNumber = 2;

		// Token: 0x040089F4 RID: 35316
		private RoleTowerPrepareSelection prepareSelection_;
	}
}
