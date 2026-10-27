using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200033E RID: 830
	public sealed class DangoBrawlDamageInfo : IMessage<DangoBrawlDamageInfo>, IMessage, IEquatable<DangoBrawlDamageInfo>, IDeepCloneable<DangoBrawlDamageInfo>, IBufferMessage
	{
		// Token: 0x06005331 RID: 21297 RVA: 0x000CAE15 File Offset: 0x000C9015
		[NullableContext(1)]
		public static DangoBrawlDamageInfo Create()
		{
			return new DangoBrawlDamageInfo();
		}

		// Token: 0x17000F18 RID: 3864
		// (get) Token: 0x06005332 RID: 21298 RVA: 0x000CAE1C File Offset: 0x000C901C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F19 RID: 3865
		// (get) Token: 0x06005333 RID: 21299 RVA: 0x000CAE1F File Offset: 0x000C901F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlDamageInfo.Descriptor;
			}
		}

		// Token: 0x06005334 RID: 21300 RVA: 0x000CAE26 File Offset: 0x000C9026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlDamageInfo()
		{
		}

		// Token: 0x06005335 RID: 21301 RVA: 0x000CAE39 File Offset: 0x000C9039
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlDamageInfo(DangoBrawlDamageInfo other) : this()
		{
			this.damages_ = other.damages_.Clone();
			this.isCrit_ = other.isCrit_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005336 RID: 21302 RVA: 0x000CAE6F File Offset: 0x000C906F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlDamageInfo Clone()
		{
			return new DangoBrawlDamageInfo(this);
		}

		// Token: 0x17000F1A RID: 3866
		// (get) Token: 0x06005337 RID: 21303 RVA: 0x000CAE77 File Offset: 0x000C9077
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoBrawlDamageSegment> Damages
		{
			get
			{
				return this.damages_;
			}
		}

		// Token: 0x17000F1B RID: 3867
		// (get) Token: 0x06005338 RID: 21304 RVA: 0x000CAE7F File Offset: 0x000C907F
		// (set) Token: 0x06005339 RID: 21305 RVA: 0x000CAE87 File Offset: 0x000C9087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsCrit
		{
			get
			{
				return this.isCrit_;
			}
			set
			{
				this.isCrit_ = value;
			}
		}

		// Token: 0x0600533A RID: 21306 RVA: 0x000CAE90 File Offset: 0x000C9090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlDamageInfo);
		}

		// Token: 0x0600533B RID: 21307 RVA: 0x000CAEA0 File Offset: 0x000C90A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlDamageInfo other)
		{
			return other != null && (other == this || (this.damages_.Equals(other.damages_) && this.IsCrit == other.IsCrit && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600533C RID: 21308 RVA: 0x000CAEF0 File Offset: 0x000C90F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.damages_.GetHashCode();
			if (this.IsCrit)
			{
				num ^= this.IsCrit.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600533D RID: 21309 RVA: 0x000CAF3D File Offset: 0x000C913D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600533E RID: 21310 RVA: 0x000CAF4A File Offset: 0x000C914A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600533F RID: 21311 RVA: 0x000CAF54 File Offset: 0x000C9154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.damages_.WriteTo(ref output, DangoBrawlDamageInfo._repeated_damages_codec);
			if (this.IsCrit)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsCrit);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005340 RID: 21312 RVA: 0x000CAFA4 File Offset: 0x000C91A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.damages_.CalculateSize(DangoBrawlDamageInfo._repeated_damages_codec);
			if (this.IsCrit)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005341 RID: 21313 RVA: 0x000CAFEC File Offset: 0x000C91EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlDamageInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.damages_.Add(other.damages_);
			if (other.IsCrit)
			{
				this.IsCrit = other.IsCrit;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005342 RID: 21314 RVA: 0x000CB039 File Offset: 0x000C9239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005343 RID: 21315 RVA: 0x000CB044 File Offset: 0x000C9244
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsCrit = input.ReadBool();
					}
				}
				else
				{
					this.damages_.AddEntriesFrom(ref input, DangoBrawlDamageInfo._repeated_damages_codec);
				}
			}
		}

		// Token: 0x04003366 RID: 13158
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003367 RID: 13159
		public const int DamagesFieldNumber = 1;

		// Token: 0x04003368 RID: 13160
		private static readonly FieldCodec<DangoBrawlDamageSegment> _repeated_damages_codec = FieldCodec.ForMessage<DangoBrawlDamageSegment>(10U, DangoBrawlDamageSegment.Parser);

		// Token: 0x04003369 RID: 13161
		private readonly RepeatedField<DangoBrawlDamageSegment> damages_ = new RepeatedField<DangoBrawlDamageSegment>();

		// Token: 0x0400336A RID: 13162
		public const int IsCritFieldNumber = 2;

		// Token: 0x0400336B RID: 13163
		private bool isCrit_;
	}
}
