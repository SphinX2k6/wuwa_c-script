using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A48 RID: 2632
	[NetMessage(EMessageId.MotorFightRefreshNextWaveGroupRequest)]
	public sealed class MotorFightRefreshNextWaveGroupRequest : IMessage<MotorFightRefreshNextWaveGroupRequest>, IMessage, IEquatable<MotorFightRefreshNextWaveGroupRequest>, IDeepCloneable<MotorFightRefreshNextWaveGroupRequest>, IBufferMessage
	{
		// Token: 0x0600E5F9 RID: 58873 RVA: 0x00219EF0 File Offset: 0x002180F0
		[NullableContext(1)]
		public static MotorFightRefreshNextWaveGroupRequest Create()
		{
			return new MotorFightRefreshNextWaveGroupRequest();
		}

		// Token: 0x17002E9C RID: 11932
		// (get) Token: 0x0600E5FA RID: 58874 RVA: 0x00219EF7 File Offset: 0x002180F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E9D RID: 11933
		// (get) Token: 0x0600E5FB RID: 58875 RVA: 0x00219EFA File Offset: 0x002180FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightRefreshNextWaveGroupRequest.Descriptor;
			}
		}

		// Token: 0x0600E5FC RID: 58876 RVA: 0x00219F01 File Offset: 0x00218101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshNextWaveGroupRequest()
		{
		}

		// Token: 0x0600E5FD RID: 58877 RVA: 0x00219F09 File Offset: 0x00218109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshNextWaveGroupRequest(MotorFightRefreshNextWaveGroupRequest other) : this()
		{
			this.waveGroupIndex_ = other.waveGroupIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E5FE RID: 58878 RVA: 0x00219F2E File Offset: 0x0021812E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshNextWaveGroupRequest Clone()
		{
			return new MotorFightRefreshNextWaveGroupRequest(this);
		}

		// Token: 0x17002E9E RID: 11934
		// (get) Token: 0x0600E5FF RID: 58879 RVA: 0x00219F36 File Offset: 0x00218136
		// (set) Token: 0x0600E600 RID: 58880 RVA: 0x00219F3E File Offset: 0x0021813E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WaveGroupIndex
		{
			get
			{
				return this.waveGroupIndex_;
			}
			set
			{
				this.waveGroupIndex_ = value;
			}
		}

		// Token: 0x0600E601 RID: 58881 RVA: 0x00219F47 File Offset: 0x00218147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightRefreshNextWaveGroupRequest);
		}

		// Token: 0x0600E602 RID: 58882 RVA: 0x00219F55 File Offset: 0x00218155
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightRefreshNextWaveGroupRequest other)
		{
			return other != null && (other == this || (this.WaveGroupIndex == other.WaveGroupIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E603 RID: 58883 RVA: 0x00219F84 File Offset: 0x00218184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WaveGroupIndex != 0)
			{
				num ^= this.WaveGroupIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E604 RID: 58884 RVA: 0x00219FC3 File Offset: 0x002181C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E605 RID: 58885 RVA: 0x00219FD0 File Offset: 0x002181D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E606 RID: 58886 RVA: 0x00219FD9 File Offset: 0x002181D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WaveGroupIndex != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.WaveGroupIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E607 RID: 58887 RVA: 0x0021A00C File Offset: 0x0021820C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WaveGroupIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WaveGroupIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E608 RID: 58888 RVA: 0x0021A04A File Offset: 0x0021824A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightRefreshNextWaveGroupRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WaveGroupIndex != 0)
			{
				this.WaveGroupIndex = other.WaveGroupIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E609 RID: 58889 RVA: 0x0021A07B File Offset: 0x0021827B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E60A RID: 58890 RVA: 0x0021A084 File Offset: 0x00218284
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
					this.WaveGroupIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005E36 RID: 24118
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E37 RID: 24119
		public const int WaveGroupIndexFieldNumber = 8;

		// Token: 0x04005E38 RID: 24120
		private int waveGroupIndex_;
	}
}
