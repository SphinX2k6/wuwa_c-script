using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A58 RID: 2648
	[NetMessage(EMessageId.MotorFightRefreshCollectionTimesChangeNotify)]
	public sealed class MotorFightRefreshCollectionTimesChangeNotify : IMessage<MotorFightRefreshCollectionTimesChangeNotify>, IMessage, IEquatable<MotorFightRefreshCollectionTimesChangeNotify>, IDeepCloneable<MotorFightRefreshCollectionTimesChangeNotify>, IBufferMessage
	{
		// Token: 0x0600E701 RID: 59137 RVA: 0x0021BF0B File Offset: 0x0021A10B
		[NullableContext(1)]
		public static MotorFightRefreshCollectionTimesChangeNotify Create()
		{
			return new MotorFightRefreshCollectionTimesChangeNotify();
		}

		// Token: 0x17002ED7 RID: 11991
		// (get) Token: 0x0600E702 RID: 59138 RVA: 0x0021BF12 File Offset: 0x0021A112
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002ED8 RID: 11992
		// (get) Token: 0x0600E703 RID: 59139 RVA: 0x0021BF15 File Offset: 0x0021A115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightRefreshCollectionTimesChangeNotify.Descriptor;
			}
		}

		// Token: 0x0600E704 RID: 59140 RVA: 0x0021BF1C File Offset: 0x0021A11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshCollectionTimesChangeNotify()
		{
		}

		// Token: 0x0600E705 RID: 59141 RVA: 0x0021BF24 File Offset: 0x0021A124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshCollectionTimesChangeNotify(MotorFightRefreshCollectionTimesChangeNotify other) : this()
		{
			this.refreshCollectionTimes_ = other.refreshCollectionTimes_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E706 RID: 59142 RVA: 0x0021BF49 File Offset: 0x0021A149
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshCollectionTimesChangeNotify Clone()
		{
			return new MotorFightRefreshCollectionTimesChangeNotify(this);
		}

		// Token: 0x17002ED9 RID: 11993
		// (get) Token: 0x0600E707 RID: 59143 RVA: 0x0021BF51 File Offset: 0x0021A151
		// (set) Token: 0x0600E708 RID: 59144 RVA: 0x0021BF59 File Offset: 0x0021A159
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

		// Token: 0x0600E709 RID: 59145 RVA: 0x0021BF62 File Offset: 0x0021A162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightRefreshCollectionTimesChangeNotify);
		}

		// Token: 0x0600E70A RID: 59146 RVA: 0x0021BF70 File Offset: 0x0021A170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightRefreshCollectionTimesChangeNotify other)
		{
			return other != null && (other == this || (this.RefreshCollectionTimes == other.RefreshCollectionTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E70B RID: 59147 RVA: 0x0021BFA0 File Offset: 0x0021A1A0
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

		// Token: 0x0600E70C RID: 59148 RVA: 0x0021BFDF File Offset: 0x0021A1DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E70D RID: 59149 RVA: 0x0021BFEC File Offset: 0x0021A1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E70E RID: 59150 RVA: 0x0021BFF5 File Offset: 0x0021A1F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RefreshCollectionTimes != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.RefreshCollectionTimes);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E70F RID: 59151 RVA: 0x0021C028 File Offset: 0x0021A228
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

		// Token: 0x0600E710 RID: 59152 RVA: 0x0021C066 File Offset: 0x0021A266
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

		// Token: 0x0600E711 RID: 59153 RVA: 0x0021C097 File Offset: 0x0021A297
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E712 RID: 59154 RVA: 0x0021C0A0 File Offset: 0x0021A2A0
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RefreshCollectionTimes = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005E2A RID: 24106
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E2B RID: 24107
		public const int RefreshCollectionTimesFieldNumber = 8;

		// Token: 0x04005E2C RID: 24108
		private int refreshCollectionTimes_;
	}
}
