using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000646 RID: 1606
	public sealed class FREvolveData : IMessage<FREvolveData>, IMessage, IEquatable<FREvolveData>, IDeepCloneable<FREvolveData>, IBufferMessage
	{
		// Token: 0x060093D5 RID: 37845 RVA: 0x00165779 File Offset: 0x00163979
		[NullableContext(1)]
		public static FREvolveData Create()
		{
			return new FREvolveData();
		}

		// Token: 0x17001D6E RID: 7534
		// (get) Token: 0x060093D6 RID: 37846 RVA: 0x00165780 File Offset: 0x00163980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D6F RID: 7535
		// (get) Token: 0x060093D7 RID: 37847 RVA: 0x00165783 File Offset: 0x00163983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FREvolveData.Descriptor;
			}
		}

		// Token: 0x060093D8 RID: 37848 RVA: 0x0016578A File Offset: 0x0016398A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FREvolveData()
		{
		}

		// Token: 0x060093D9 RID: 37849 RVA: 0x00165792 File Offset: 0x00163992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FREvolveData(FREvolveData other) : this()
		{
			this.curExp_ = other.curExp_;
			this.curLevel_ = other.curLevel_;
			this.expPerLevel_ = other.expPerLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060093DA RID: 37850 RVA: 0x001657CF File Offset: 0x001639CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FREvolveData Clone()
		{
			return new FREvolveData(this);
		}

		// Token: 0x17001D70 RID: 7536
		// (get) Token: 0x060093DB RID: 37851 RVA: 0x001657D7 File Offset: 0x001639D7
		// (set) Token: 0x060093DC RID: 37852 RVA: 0x001657DF File Offset: 0x001639DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurExp
		{
			get
			{
				return this.curExp_;
			}
			set
			{
				this.curExp_ = value;
			}
		}

		// Token: 0x17001D71 RID: 7537
		// (get) Token: 0x060093DD RID: 37853 RVA: 0x001657E8 File Offset: 0x001639E8
		// (set) Token: 0x060093DE RID: 37854 RVA: 0x001657F0 File Offset: 0x001639F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurLevel
		{
			get
			{
				return this.curLevel_;
			}
			set
			{
				this.curLevel_ = value;
			}
		}

		// Token: 0x17001D72 RID: 7538
		// (get) Token: 0x060093DF RID: 37855 RVA: 0x001657F9 File Offset: 0x001639F9
		// (set) Token: 0x060093E0 RID: 37856 RVA: 0x00165801 File Offset: 0x00163A01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ExpPerLevel
		{
			get
			{
				return this.expPerLevel_;
			}
			set
			{
				this.expPerLevel_ = value;
			}
		}

		// Token: 0x060093E1 RID: 37857 RVA: 0x0016580A File Offset: 0x00163A0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FREvolveData);
		}

		// Token: 0x060093E2 RID: 37858 RVA: 0x00165818 File Offset: 0x00163A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FREvolveData other)
		{
			return other != null && (other == this || (this.CurExp == other.CurExp && this.CurLevel == other.CurLevel && this.ExpPerLevel == other.ExpPerLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060093E3 RID: 37859 RVA: 0x00165874 File Offset: 0x00163A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurExp != 0)
			{
				num ^= this.CurExp.GetHashCode();
			}
			if (this.CurLevel != 0)
			{
				num ^= this.CurLevel.GetHashCode();
			}
			if (this.ExpPerLevel != 0)
			{
				num ^= this.ExpPerLevel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060093E4 RID: 37860 RVA: 0x001658E5 File Offset: 0x00163AE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060093E5 RID: 37861 RVA: 0x001658F2 File Offset: 0x00163AF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060093E6 RID: 37862 RVA: 0x001658FC File Offset: 0x00163AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurExp != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CurExp);
			}
			if (this.CurLevel != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CurLevel);
			}
			if (this.ExpPerLevel != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ExpPerLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060093E7 RID: 37863 RVA: 0x00165970 File Offset: 0x00163B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurExp);
			}
			if (this.CurLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurLevel);
			}
			if (this.ExpPerLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExpPerLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060093E8 RID: 37864 RVA: 0x001659E0 File Offset: 0x00163BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FREvolveData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurExp != 0)
			{
				this.CurExp = other.CurExp;
			}
			if (other.CurLevel != 0)
			{
				this.CurLevel = other.CurLevel;
			}
			if (other.ExpPerLevel != 0)
			{
				this.ExpPerLevel = other.ExpPerLevel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060093E9 RID: 37865 RVA: 0x00165A44 File Offset: 0x00163C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060093EA RID: 37866 RVA: 0x00165A50 File Offset: 0x00163C50
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ExpPerLevel = input.ReadInt32();
						}
					}
					else
					{
						this.CurLevel = input.ReadInt32();
					}
				}
				else
				{
					this.CurExp = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004700 RID: 18176
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004701 RID: 18177
		public const int CurExpFieldNumber = 1;

		// Token: 0x04004702 RID: 18178
		private int curExp_;

		// Token: 0x04004703 RID: 18179
		public const int CurLevelFieldNumber = 2;

		// Token: 0x04004704 RID: 18180
		private int curLevel_;

		// Token: 0x04004705 RID: 18181
		public const int ExpPerLevelFieldNumber = 3;

		// Token: 0x04004706 RID: 18182
		private int expPerLevel_;
	}
}
