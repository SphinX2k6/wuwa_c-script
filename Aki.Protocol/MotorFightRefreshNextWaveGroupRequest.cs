using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A59 RID: 2649
	[NetMessage(EMessageId.MotorFightRefreshNextWaveGroupRequest)]
	public sealed class MotorFightRefreshNextWaveGroupRequest : IMessage<MotorFightRefreshNextWaveGroupRequest>, IMessage, IEquatable<MotorFightRefreshNextWaveGroupRequest>, IDeepCloneable<MotorFightRefreshNextWaveGroupRequest>, IBufferMessage
	{
		// Token: 0x0600E713 RID: 59155 RVA: 0x0021C0E5 File Offset: 0x0021A2E5
		[NullableContext(1)]
		public static MotorFightRefreshNextWaveGroupRequest Create()
		{
			return new MotorFightRefreshNextWaveGroupRequest();
		}

		// Token: 0x17002EDA RID: 11994
		// (get) Token: 0x0600E714 RID: 59156 RVA: 0x0021C0EC File Offset: 0x0021A2EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002EDB RID: 11995
		// (get) Token: 0x0600E715 RID: 59157 RVA: 0x0021C0EF File Offset: 0x0021A2EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightRefreshNextWaveGroupRequest.Descriptor;
			}
		}

		// Token: 0x0600E716 RID: 59158 RVA: 0x0021C0F6 File Offset: 0x0021A2F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshNextWaveGroupRequest()
		{
		}

		// Token: 0x0600E717 RID: 59159 RVA: 0x0021C0FE File Offset: 0x0021A2FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshNextWaveGroupRequest(MotorFightRefreshNextWaveGroupRequest other) : this()
		{
			this.waveGroupIndex_ = other.waveGroupIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E718 RID: 59160 RVA: 0x0021C123 File Offset: 0x0021A323
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshNextWaveGroupRequest Clone()
		{
			return new MotorFightRefreshNextWaveGroupRequest(this);
		}

		// Token: 0x17002EDC RID: 11996
		// (get) Token: 0x0600E719 RID: 59161 RVA: 0x0021C12B File Offset: 0x0021A32B
		// (set) Token: 0x0600E71A RID: 59162 RVA: 0x0021C133 File Offset: 0x0021A333
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

		// Token: 0x0600E71B RID: 59163 RVA: 0x0021C13C File Offset: 0x0021A33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightRefreshNextWaveGroupRequest);
		}

		// Token: 0x0600E71C RID: 59164 RVA: 0x0021C14A File Offset: 0x0021A34A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightRefreshNextWaveGroupRequest other)
		{
			return other != null && (other == this || (this.WaveGroupIndex == other.WaveGroupIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E71D RID: 59165 RVA: 0x0021C178 File Offset: 0x0021A378
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

		// Token: 0x0600E71E RID: 59166 RVA: 0x0021C1B7 File Offset: 0x0021A3B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E71F RID: 59167 RVA: 0x0021C1C4 File Offset: 0x0021A3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E720 RID: 59168 RVA: 0x0021C1CD File Offset: 0x0021A3CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WaveGroupIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.WaveGroupIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E721 RID: 59169 RVA: 0x0021C200 File Offset: 0x0021A400
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

		// Token: 0x0600E722 RID: 59170 RVA: 0x0021C23E File Offset: 0x0021A43E
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

		// Token: 0x0600E723 RID: 59171 RVA: 0x0021C26F File Offset: 0x0021A46F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E724 RID: 59172 RVA: 0x0021C278 File Offset: 0x0021A478
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.WaveGroupIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005E2D RID: 24109
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E2E RID: 24110
		public const int WaveGroupIndexFieldNumber = 2;

		// Token: 0x04005E2F RID: 24111
		private int waveGroupIndex_;
	}
}
