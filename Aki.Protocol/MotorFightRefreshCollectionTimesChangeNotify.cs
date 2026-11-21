using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A47 RID: 2631
	[NetMessage(EMessageId.MotorFightRefreshCollectionTimesChangeNotify)]
	public sealed class MotorFightRefreshCollectionTimesChangeNotify : IMessage<MotorFightRefreshCollectionTimesChangeNotify>, IMessage, IEquatable<MotorFightRefreshCollectionTimesChangeNotify>, IDeepCloneable<MotorFightRefreshCollectionTimesChangeNotify>, IBufferMessage
	{
		// Token: 0x0600E5E7 RID: 58855 RVA: 0x00219D17 File Offset: 0x00217F17
		[NullableContext(1)]
		public static MotorFightRefreshCollectionTimesChangeNotify Create()
		{
			return new MotorFightRefreshCollectionTimesChangeNotify();
		}

		// Token: 0x17002E99 RID: 11929
		// (get) Token: 0x0600E5E8 RID: 58856 RVA: 0x00219D1E File Offset: 0x00217F1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E9A RID: 11930
		// (get) Token: 0x0600E5E9 RID: 58857 RVA: 0x00219D21 File Offset: 0x00217F21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightRefreshCollectionTimesChangeNotify.Descriptor;
			}
		}

		// Token: 0x0600E5EA RID: 58858 RVA: 0x00219D28 File Offset: 0x00217F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshCollectionTimesChangeNotify()
		{
		}

		// Token: 0x0600E5EB RID: 58859 RVA: 0x00219D30 File Offset: 0x00217F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshCollectionTimesChangeNotify(MotorFightRefreshCollectionTimesChangeNotify other) : this()
		{
			this.refreshCollectionTimes_ = other.refreshCollectionTimes_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E5EC RID: 58860 RVA: 0x00219D55 File Offset: 0x00217F55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshCollectionTimesChangeNotify Clone()
		{
			return new MotorFightRefreshCollectionTimesChangeNotify(this);
		}

		// Token: 0x17002E9B RID: 11931
		// (get) Token: 0x0600E5ED RID: 58861 RVA: 0x00219D5D File Offset: 0x00217F5D
		// (set) Token: 0x0600E5EE RID: 58862 RVA: 0x00219D65 File Offset: 0x00217F65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RefreshCollectionTimes
		{
			get
			{
				return this.refreshCollectionTimes_;
			}
			set
			{
				this.refreshCollectionTimes_ = value;
			}
		}

		// Token: 0x0600E5EF RID: 58863 RVA: 0x00219D6E File Offset: 0x00217F6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightRefreshCollectionTimesChangeNotify);
		}

		// Token: 0x0600E5F0 RID: 58864 RVA: 0x00219D7C File Offset: 0x00217F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightRefreshCollectionTimesChangeNotify other)
		{
			return other != null && (other == this || (this.RefreshCollectionTimes == other.RefreshCollectionTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E5F1 RID: 58865 RVA: 0x00219DAC File Offset: 0x00217FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RefreshCollectionTimes != 0)
			{
				num ^= this.RefreshCollectionTimes.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E5F2 RID: 58866 RVA: 0x00219DEB File Offset: 0x00217FEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E5F3 RID: 58867 RVA: 0x00219DF8 File Offset: 0x00217FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E5F4 RID: 58868 RVA: 0x00219E01 File Offset: 0x00218001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RefreshCollectionTimes != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RefreshCollectionTimes);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E5F5 RID: 58869 RVA: 0x00219E34 File Offset: 0x00218034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RefreshCollectionTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RefreshCollectionTimes);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E5F6 RID: 58870 RVA: 0x00219E72 File Offset: 0x00218072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightRefreshCollectionTimesChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RefreshCollectionTimes != 0)
			{
				this.RefreshCollectionTimes = other.RefreshCollectionTimes;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E5F7 RID: 58871 RVA: 0x00219EA3 File Offset: 0x002180A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E5F8 RID: 58872 RVA: 0x00219EAC File Offset: 0x002180AC
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
					this.RefreshCollectionTimes = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005E33 RID: 24115
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E34 RID: 24116
		public const int RefreshCollectionTimesFieldNumber = 1;

		// Token: 0x04005E35 RID: 24117
		private int refreshCollectionTimes_;
	}
}
