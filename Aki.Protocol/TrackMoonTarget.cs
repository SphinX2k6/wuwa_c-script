using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200145F RID: 5215
	public sealed class TrackMoonTarget : IMessage<TrackMoonTarget>, IMessage, IEquatable<TrackMoonTarget>, IDeepCloneable<TrackMoonTarget>, IBufferMessage
	{
		// Token: 0x0601BAFE RID: 113406 RVA: 0x0040538E File Offset: 0x0040358E
		[NullableContext(1)]
		public static TrackMoonTarget Create()
		{
			return new TrackMoonTarget();
		}

		// Token: 0x17005DAB RID: 23979
		// (get) Token: 0x0601BAFF RID: 113407 RVA: 0x00405395 File Offset: 0x00403595
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TrackMoonTarget> Parser
		{
			get
			{
				return TrackMoonTarget._parser;
			}
		}

		// Token: 0x17005DAC RID: 23980
		// (get) Token: 0x0601BB00 RID: 113408 RVA: 0x0040539C File Offset: 0x0040359C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DAD RID: 23981
		// (get) Token: 0x0601BB01 RID: 113409 RVA: 0x0040539F File Offset: 0x0040359F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonTarget.Descriptor;
			}
		}

		// Token: 0x0601BB02 RID: 113410 RVA: 0x004053A6 File Offset: 0x004035A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonTarget()
		{
		}

		// Token: 0x0601BB03 RID: 113411 RVA: 0x004053B0 File Offset: 0x004035B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonTarget(TrackMoonTarget other) : this()
		{
			this.id_ = other.id_;
			this.current_ = other.current_;
			this.target_ = other.target_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BB04 RID: 113412 RVA: 0x00405404 File Offset: 0x00403604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonTarget Clone()
		{
			return new TrackMoonTarget(this);
		}

		// Token: 0x17005DAE RID: 23982
		// (get) Token: 0x0601BB05 RID: 113413 RVA: 0x0040540C File Offset: 0x0040360C
		// (set) Token: 0x0601BB06 RID: 113414 RVA: 0x00405414 File Offset: 0x00403614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17005DAF RID: 23983
		// (get) Token: 0x0601BB07 RID: 113415 RVA: 0x0040541D File Offset: 0x0040361D
		// (set) Token: 0x0601BB08 RID: 113416 RVA: 0x00405425 File Offset: 0x00403625
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Current
		{
			get
			{
				return this.current_;
			}
			set
			{
				this.current_ = value;
			}
		}

		// Token: 0x17005DB0 RID: 23984
		// (get) Token: 0x0601BB09 RID: 113417 RVA: 0x0040542E File Offset: 0x0040362E
		// (set) Token: 0x0601BB0A RID: 113418 RVA: 0x00405436 File Offset: 0x00403636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Target
		{
			get
			{
				return this.target_;
			}
			set
			{
				this.target_ = value;
			}
		}

		// Token: 0x17005DB1 RID: 23985
		// (get) Token: 0x0601BB0B RID: 113419 RVA: 0x0040543F File Offset: 0x0040363F
		// (set) Token: 0x0601BB0C RID: 113420 RVA: 0x00405447 File Offset: 0x00403647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonTargetState Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x0601BB0D RID: 113421 RVA: 0x00405450 File Offset: 0x00403650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonTarget);
		}

		// Token: 0x0601BB0E RID: 113422 RVA: 0x00405460 File Offset: 0x00403660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonTarget other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Current == other.Current && this.Target == other.Target && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BB0F RID: 113423 RVA: 0x004054CC File Offset: 0x004036CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Current != 0)
			{
				int num2 = num;
				int num3 = this.Current;
				num = (num2 ^ num3.GetHashCode());
			}
			if (this.Target != 0)
			{
				num ^= this.Target.GetHashCode();
			}
			if (this.Status != TrackMoonTargetState.TrackMoonTargetRunning)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BB10 RID: 113424 RVA: 0x0040555C File Offset: 0x0040375C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BB11 RID: 113425 RVA: 0x00405569 File Offset: 0x00403769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BB12 RID: 113426 RVA: 0x00405574 File Offset: 0x00403774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Current != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Current);
			}
			if (this.Target != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Target);
			}
			if (this.Status != TrackMoonTargetState.TrackMoonTargetRunning)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BB13 RID: 113427 RVA: 0x00405604 File Offset: 0x00403804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Current != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Current);
			}
			if (this.Target != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Target);
			}
			if (this.Status != TrackMoonTargetState.TrackMoonTargetRunning)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BB14 RID: 113428 RVA: 0x0040568C File Offset: 0x0040388C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrackMoonTarget other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Current != 0)
			{
				this.Current = other.Current;
			}
			if (other.Target != 0)
			{
				this.Target = other.Target;
			}
			if (other.Status != TrackMoonTargetState.TrackMoonTargetRunning)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BB15 RID: 113429 RVA: 0x00405704 File Offset: 0x00403904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BB16 RID: 113430 RVA: 0x00405710 File Offset: 0x00403910
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Current = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Target = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Status = (TrackMoonTargetState)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A0BB RID: 41147
		private static readonly MessageParser<TrackMoonTarget> _parser = new MessageParser<TrackMoonTarget>(() => new TrackMoonTarget());

		// Token: 0x0400A0BC RID: 41148
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A0BD RID: 41149
		public const int IdFieldNumber = 1;

		// Token: 0x0400A0BE RID: 41150
		private int id_;

		// Token: 0x0400A0BF RID: 41151
		public const int CurrentFieldNumber = 2;

		// Token: 0x0400A0C0 RID: 41152
		private int current_;

		// Token: 0x0400A0C1 RID: 41153
		public const int TargetFieldNumber = 3;

		// Token: 0x0400A0C2 RID: 41154
		private int target_;

		// Token: 0x0400A0C3 RID: 41155
		public const int StatusFieldNumber = 4;

		// Token: 0x0400A0C4 RID: 41156
		private TrackMoonTargetState status_;
	}
}
