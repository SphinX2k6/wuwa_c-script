using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014C7 RID: 5319
	public sealed class VarRefPb : IMessage<VarRefPb>, IMessage, IEquatable<VarRefPb>, IDeepCloneable<VarRefPb>, IBufferMessage
	{
		// Token: 0x0601C21B RID: 115227 RVA: 0x0041108A File Offset: 0x0040F28A
		[NullableContext(1)]
		public static VarRefPb Create()
		{
			return new VarRefPb();
		}

		// Token: 0x17005ED8 RID: 24280
		// (get) Token: 0x0601C21C RID: 115228 RVA: 0x00411091 File Offset: 0x0040F291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005ED9 RID: 24281
		// (get) Token: 0x0601C21D RID: 115229 RVA: 0x00411094 File Offset: 0x0040F294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VarRefPb.Descriptor;
			}
		}

		// Token: 0x0601C21E RID: 115230 RVA: 0x0041109B File Offset: 0x0040F29B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VarRefPb()
		{
		}

		// Token: 0x0601C21F RID: 115231 RVA: 0x004110A4 File Offset: 0x0040F2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VarRefPb(VarRefPb other) : this()
		{
			this.sourceType_ = other.sourceType_;
			switch (other.VarRefCase)
			{
			case VarRefPb.VarRefOneofCase.ConstVarRef:
				this.ConstVarRef = other.ConstVarRef.Clone();
				break;
			case VarRefPb.VarRefOneofCase.SelfVarRef:
				this.SelfVarRef = other.SelfVarRef.Clone();
				break;
			case VarRefPb.VarRefOneofCase.GlobalVarRef:
				this.GlobalVarRef = other.GlobalVarRef.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C220 RID: 115232 RVA: 0x00411128 File Offset: 0x0040F328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VarRefPb Clone()
		{
			return new VarRefPb(this);
		}

		// Token: 0x17005EDA RID: 24282
		// (get) Token: 0x0601C221 RID: 115233 RVA: 0x00411130 File Offset: 0x0040F330
		// (set) Token: 0x0601C222 RID: 115234 RVA: 0x00411138 File Offset: 0x0040F338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SourceType
		{
			get
			{
				return this.sourceType_;
			}
			set
			{
				this.sourceType_ = value;
			}
		}

		// Token: 0x17005EDB RID: 24283
		// (get) Token: 0x0601C223 RID: 115235 RVA: 0x00411141 File Offset: 0x0040F341
		// (set) Token: 0x0601C224 RID: 115236 RVA: 0x00411159 File Offset: 0x0040F359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConstVarRefPb ConstVarRef
		{
			get
			{
				if (this.varRefCase_ != VarRefPb.VarRefOneofCase.ConstVarRef)
				{
					return null;
				}
				return (ConstVarRefPb)this.varRef_;
			}
			set
			{
				this.varRef_ = value;
				this.varRefCase_ = ((value == null) ? VarRefPb.VarRefOneofCase.None : VarRefPb.VarRefOneofCase.ConstVarRef);
			}
		}

		// Token: 0x17005EDC RID: 24284
		// (get) Token: 0x0601C225 RID: 115237 RVA: 0x0041116F File Offset: 0x0040F36F
		// (set) Token: 0x0601C226 RID: 115238 RVA: 0x00411187 File Offset: 0x0040F387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelfVarRefPb SelfVarRef
		{
			get
			{
				if (this.varRefCase_ != VarRefPb.VarRefOneofCase.SelfVarRef)
				{
					return null;
				}
				return (SelfVarRefPb)this.varRef_;
			}
			set
			{
				this.varRef_ = value;
				this.varRefCase_ = ((value == null) ? VarRefPb.VarRefOneofCase.None : VarRefPb.VarRefOneofCase.SelfVarRef);
			}
		}

		// Token: 0x17005EDD RID: 24285
		// (get) Token: 0x0601C227 RID: 115239 RVA: 0x0041119D File Offset: 0x0040F39D
		// (set) Token: 0x0601C228 RID: 115240 RVA: 0x004111B5 File Offset: 0x0040F3B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GlobalVarRefPb GlobalVarRef
		{
			get
			{
				if (this.varRefCase_ != VarRefPb.VarRefOneofCase.GlobalVarRef)
				{
					return null;
				}
				return (GlobalVarRefPb)this.varRef_;
			}
			set
			{
				this.varRef_ = value;
				this.varRefCase_ = ((value == null) ? VarRefPb.VarRefOneofCase.None : VarRefPb.VarRefOneofCase.GlobalVarRef);
			}
		}

		// Token: 0x17005EDE RID: 24286
		// (get) Token: 0x0601C229 RID: 115241 RVA: 0x004111CB File Offset: 0x0040F3CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VarRefPb.VarRefOneofCase VarRefCase
		{
			get
			{
				return this.varRefCase_;
			}
		}

		// Token: 0x0601C22A RID: 115242 RVA: 0x004111D3 File Offset: 0x0040F3D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearVarRef()
		{
			this.varRefCase_ = VarRefPb.VarRefOneofCase.None;
			this.varRef_ = null;
		}

		// Token: 0x0601C22B RID: 115243 RVA: 0x004111E3 File Offset: 0x0040F3E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VarRefPb);
		}

		// Token: 0x0601C22C RID: 115244 RVA: 0x004111F4 File Offset: 0x0040F3F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VarRefPb other)
		{
			return other != null && (other == this || (this.SourceType == other.SourceType && object.Equals(this.ConstVarRef, other.ConstVarRef) && object.Equals(this.SelfVarRef, other.SelfVarRef) && object.Equals(this.GlobalVarRef, other.GlobalVarRef) && this.VarRefCase == other.VarRefCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C22D RID: 115245 RVA: 0x0041127C File Offset: 0x0040F47C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SourceType != 0)
			{
				num ^= this.SourceType.GetHashCode();
			}
			if (this.varRefCase_ == VarRefPb.VarRefOneofCase.ConstVarRef)
			{
				num ^= this.ConstVarRef.GetHashCode();
			}
			if (this.varRefCase_ == VarRefPb.VarRefOneofCase.SelfVarRef)
			{
				num ^= this.SelfVarRef.GetHashCode();
			}
			if (this.varRefCase_ == VarRefPb.VarRefOneofCase.GlobalVarRef)
			{
				num ^= this.GlobalVarRef.GetHashCode();
			}
			num ^= (int)this.varRefCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C22E RID: 115246 RVA: 0x00411309 File Offset: 0x0040F509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C22F RID: 115247 RVA: 0x00411316 File Offset: 0x0040F516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C230 RID: 115248 RVA: 0x00411320 File Offset: 0x0040F520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SourceType != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SourceType);
			}
			if (this.varRefCase_ == VarRefPb.VarRefOneofCase.ConstVarRef)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ConstVarRef);
			}
			if (this.varRefCase_ == VarRefPb.VarRefOneofCase.SelfVarRef)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.SelfVarRef);
			}
			if (this.varRefCase_ == VarRefPb.VarRefOneofCase.GlobalVarRef)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.GlobalVarRef);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C231 RID: 115249 RVA: 0x004113B4 File Offset: 0x0040F5B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SourceType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SourceType);
			}
			if (this.varRefCase_ == VarRefPb.VarRefOneofCase.ConstVarRef)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ConstVarRef);
			}
			if (this.varRefCase_ == VarRefPb.VarRefOneofCase.SelfVarRef)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SelfVarRef);
			}
			if (this.varRefCase_ == VarRefPb.VarRefOneofCase.GlobalVarRef)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GlobalVarRef);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C232 RID: 115250 RVA: 0x00411440 File Offset: 0x0040F640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VarRefPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SourceType != 0)
			{
				this.SourceType = other.SourceType;
			}
			switch (other.VarRefCase)
			{
			case VarRefPb.VarRefOneofCase.ConstVarRef:
				if (this.ConstVarRef == null)
				{
					this.ConstVarRef = new ConstVarRefPb();
				}
				this.ConstVarRef.MergeFrom(other.ConstVarRef);
				break;
			case VarRefPb.VarRefOneofCase.SelfVarRef:
				if (this.SelfVarRef == null)
				{
					this.SelfVarRef = new SelfVarRefPb();
				}
				this.SelfVarRef.MergeFrom(other.SelfVarRef);
				break;
			case VarRefPb.VarRefOneofCase.GlobalVarRef:
				if (this.GlobalVarRef == null)
				{
					this.GlobalVarRef = new GlobalVarRefPb();
				}
				this.GlobalVarRef.MergeFrom(other.GlobalVarRef);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C233 RID: 115251 RVA: 0x00411509 File Offset: 0x0040F709
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C234 RID: 115252 RVA: 0x00411514 File Offset: 0x0040F714
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
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.SourceType = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						ConstVarRefPb constVarRefPb = new ConstVarRefPb();
						if (this.varRefCase_ == VarRefPb.VarRefOneofCase.ConstVarRef)
						{
							constVarRefPb.MergeFrom(this.ConstVarRef);
						}
						input.ReadMessage(constVarRefPb);
						this.ConstVarRef = constVarRefPb;
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						SelfVarRefPb selfVarRefPb = new SelfVarRefPb();
						if (this.varRefCase_ == VarRefPb.VarRefOneofCase.SelfVarRef)
						{
							selfVarRefPb.MergeFrom(this.SelfVarRef);
						}
						input.ReadMessage(selfVarRefPb);
						this.SelfVarRef = selfVarRefPb;
						continue;
					}
					if (num == 34U)
					{
						GlobalVarRefPb globalVarRefPb = new GlobalVarRefPb();
						if (this.varRefCase_ == VarRefPb.VarRefOneofCase.GlobalVarRef)
						{
							globalVarRefPb.MergeFrom(this.GlobalVarRef);
						}
						input.ReadMessage(globalVarRefPb);
						this.GlobalVarRef = globalVarRefPb;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A172 RID: 41330
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A173 RID: 41331
		public const int SourceTypeFieldNumber = 1;

		// Token: 0x0400A174 RID: 41332
		private int sourceType_;

		// Token: 0x0400A175 RID: 41333
		public const int ConstVarRefFieldNumber = 2;

		// Token: 0x0400A176 RID: 41334
		public const int SelfVarRefFieldNumber = 3;

		// Token: 0x0400A177 RID: 41335
		public const int GlobalVarRefFieldNumber = 4;

		// Token: 0x0400A178 RID: 41336
		private object varRef_;

		// Token: 0x0400A179 RID: 41337
		private VarRefPb.VarRefOneofCase varRefCase_;

		// Token: 0x020019ED RID: 6637
		public enum VarRefOneofCase
		{
			// Token: 0x0400CAD4 RID: 51924
			None,
			// Token: 0x0400CAD5 RID: 51925
			ConstVarRef = 2,
			// Token: 0x0400CAD6 RID: 51926
			SelfVarRef,
			// Token: 0x0400CAD7 RID: 51927
			GlobalVarRef
		}
	}
}
