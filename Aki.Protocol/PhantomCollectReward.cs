using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CB7 RID: 3255
	public sealed class PhantomCollectReward : IMessage<PhantomCollectReward>, IMessage, IEquatable<PhantomCollectReward>, IDeepCloneable<PhantomCollectReward>, IBufferMessage
	{
		// Token: 0x06011A59 RID: 72281 RVA: 0x00295C1E File Offset: 0x00293E1E
		[NullableContext(1)]
		public static PhantomCollectReward Create()
		{
			return new PhantomCollectReward();
		}

		// Token: 0x17003A74 RID: 14964
		// (get) Token: 0x06011A5A RID: 72282 RVA: 0x00295C25 File Offset: 0x00293E25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomCollectReward> Parser
		{
			get
			{
				return PhantomCollectReward._parser;
			}
		}

		// Token: 0x17003A75 RID: 14965
		// (get) Token: 0x06011A5B RID: 72283 RVA: 0x00295C2C File Offset: 0x00293E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A76 RID: 14966
		// (get) Token: 0x06011A5C RID: 72284 RVA: 0x00295C2F File Offset: 0x00293E2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomCollectReward.Descriptor;
			}
		}

		// Token: 0x06011A5D RID: 72285 RVA: 0x00295C36 File Offset: 0x00293E36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectReward()
		{
		}

		// Token: 0x06011A5E RID: 72286 RVA: 0x00295C40 File Offset: 0x00293E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectReward(PhantomCollectReward other) : this()
		{
			this.type_ = other.type_;
			this.state_ = other.state_;
			if (other.DataCase == PhantomCollectReward.DataOneofCase.Progress)
			{
				this.Progress = other.Progress.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011A5F RID: 72287 RVA: 0x00295C96 File Offset: 0x00293E96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectReward Clone()
		{
			return new PhantomCollectReward(this);
		}

		// Token: 0x17003A77 RID: 14967
		// (get) Token: 0x06011A60 RID: 72288 RVA: 0x00295C9E File Offset: 0x00293E9E
		// (set) Token: 0x06011A61 RID: 72289 RVA: 0x00295CA6 File Offset: 0x00293EA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectRewardType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17003A78 RID: 14968
		// (get) Token: 0x06011A62 RID: 72290 RVA: 0x00295CAF File Offset: 0x00293EAF
		// (set) Token: 0x06011A63 RID: 72291 RVA: 0x00295CB7 File Offset: 0x00293EB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x17003A79 RID: 14969
		// (get) Token: 0x06011A64 RID: 72292 RVA: 0x00295CC0 File Offset: 0x00293EC0
		// (set) Token: 0x06011A65 RID: 72293 RVA: 0x00295CD8 File Offset: 0x00293ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectProgress Progress
		{
			get
			{
				if (this.dataCase_ != PhantomCollectReward.DataOneofCase.Progress)
				{
					return null;
				}
				return (PhantomCollectProgress)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? PhantomCollectReward.DataOneofCase.None : PhantomCollectReward.DataOneofCase.Progress);
			}
		}

		// Token: 0x17003A7A RID: 14970
		// (get) Token: 0x06011A66 RID: 72294 RVA: 0x00295CEE File Offset: 0x00293EEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectReward.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06011A67 RID: 72295 RVA: 0x00295CF6 File Offset: 0x00293EF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = PhantomCollectReward.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06011A68 RID: 72296 RVA: 0x00295D06 File Offset: 0x00293F06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomCollectReward);
		}

		// Token: 0x06011A69 RID: 72297 RVA: 0x00295D14 File Offset: 0x00293F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomCollectReward other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.State == other.State && object.Equals(this.Progress, other.Progress) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011A6A RID: 72298 RVA: 0x00295D84 File Offset: 0x00293F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != PhantomCollectRewardType.PhantomsCollect)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.State != SignState.Lock)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.dataCase_ == PhantomCollectReward.DataOneofCase.Progress)
			{
				num ^= this.Progress.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011A6B RID: 72299 RVA: 0x00295E08 File Offset: 0x00294008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011A6C RID: 72300 RVA: 0x00295E15 File Offset: 0x00294015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011A6D RID: 72301 RVA: 0x00295E20 File Offset: 0x00294020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != PhantomCollectRewardType.PhantomsCollect)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Type);
			}
			if (this.State != SignState.Lock)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.State);
			}
			if (this.dataCase_ == PhantomCollectReward.DataOneofCase.Progress)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Progress);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011A6E RID: 72302 RVA: 0x00295E98 File Offset: 0x00294098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != PhantomCollectRewardType.PhantomsCollect)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.State != SignState.Lock)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this.dataCase_ == PhantomCollectReward.DataOneofCase.Progress)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Progress);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011A6F RID: 72303 RVA: 0x00295F08 File Offset: 0x00294108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomCollectReward other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != PhantomCollectRewardType.PhantomsCollect)
			{
				this.Type = other.Type;
			}
			if (other.State != SignState.Lock)
			{
				this.State = other.State;
			}
			if (other.DataCase == PhantomCollectReward.DataOneofCase.Progress)
			{
				if (this.Progress == null)
				{
					this.Progress = new PhantomCollectProgress();
				}
				this.Progress.MergeFrom(other.Progress);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011A70 RID: 72304 RVA: 0x00295F85 File Offset: 0x00294185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011A71 RID: 72305 RVA: 0x00295F90 File Offset: 0x00294190
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
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							PhantomCollectProgress phantomCollectProgress = new PhantomCollectProgress();
							if (this.dataCase_ == PhantomCollectReward.DataOneofCase.Progress)
							{
								phantomCollectProgress.MergeFrom(this.Progress);
							}
							input.ReadMessage(phantomCollectProgress);
							this.Progress = phantomCollectProgress;
						}
					}
					else
					{
						this.State = (SignState)input.ReadEnum();
					}
				}
				else
				{
					this.Type = (PhantomCollectRewardType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006F71 RID: 28529
		private static readonly MessageParser<PhantomCollectReward> _parser = new MessageParser<PhantomCollectReward>(() => new PhantomCollectReward());

		// Token: 0x04006F72 RID: 28530
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F73 RID: 28531
		public const int TypeFieldNumber = 1;

		// Token: 0x04006F74 RID: 28532
		private PhantomCollectRewardType type_;

		// Token: 0x04006F75 RID: 28533
		public const int StateFieldNumber = 2;

		// Token: 0x04006F76 RID: 28534
		private SignState state_;

		// Token: 0x04006F77 RID: 28535
		public const int ProgressFieldNumber = 3;

		// Token: 0x04006F78 RID: 28536
		private object data_;

		// Token: 0x04006F79 RID: 28537
		private PhantomCollectReward.DataOneofCase dataCase_;

		// Token: 0x02001930 RID: 6448
		public enum DataOneofCase
		{
			// Token: 0x0400CDE7 RID: 52711
			None,
			// Token: 0x0400CDE8 RID: 52712
			Progress = 3
		}
	}
}
