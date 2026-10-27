using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000B8 RID: 184
	public sealed class AdventreTask : IMessage<AdventreTask>, IMessage, IEquatable<AdventreTask>, IDeepCloneable<AdventreTask>, IBufferMessage
	{
		// Token: 0x06001E13 RID: 7699 RVA: 0x00052419 File Offset: 0x00050619
		[NullableContext(1)]
		public static AdventreTask Create()
		{
			return new AdventreTask();
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06001E14 RID: 7700 RVA: 0x00052420 File Offset: 0x00050620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AdventreTask> Parser
		{
			get
			{
				return AdventreTask._parser;
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06001E15 RID: 7701 RVA: 0x00052427 File Offset: 0x00050627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06001E16 RID: 7702 RVA: 0x0005242A File Offset: 0x0005062A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdventreTask.Descriptor;
			}
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x00052431 File Offset: 0x00050631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventreTask()
		{
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x00052439 File Offset: 0x00050639
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventreTask(AdventreTask other) : this()
		{
			this.id_ = other.id_;
			this.state_ = other.state_;
			this.adventreProgress_ = other.adventreProgress_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x00052476 File Offset: 0x00050676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventreTask Clone()
		{
			return new AdventreTask(this);
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06001E1A RID: 7706 RVA: 0x0005247E File Offset: 0x0005067E
		// (set) Token: 0x06001E1B RID: 7707 RVA: 0x00052486 File Offset: 0x00050686
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

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06001E1C RID: 7708 RVA: 0x0005248F File Offset: 0x0005068F
		// (set) Token: 0x06001E1D RID: 7709 RVA: 0x00052497 File Offset: 0x00050697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int State
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

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06001E1E RID: 7710 RVA: 0x000524A0 File Offset: 0x000506A0
		// (set) Token: 0x06001E1F RID: 7711 RVA: 0x000524A8 File Offset: 0x000506A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AdventreProgress
		{
			get
			{
				return this.adventreProgress_;
			}
			set
			{
				this.adventreProgress_ = value;
			}
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x000524B1 File Offset: 0x000506B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdventreTask);
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x000524C0 File Offset: 0x000506C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdventreTask other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.State == other.State && this.AdventreProgress == other.AdventreProgress && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001E22 RID: 7714 RVA: 0x0005251C File Offset: 0x0005071C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.State != 0)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.AdventreProgress != 0)
			{
				num ^= this.AdventreProgress.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x0005258D File Offset: 0x0005078D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x0005259A File Offset: 0x0005079A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001E25 RID: 7717 RVA: 0x000525A4 File Offset: 0x000507A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.State != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.State);
			}
			if (this.AdventreProgress != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.AdventreProgress);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x00052618 File Offset: 0x00050818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.State != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.State);
			}
			if (this.AdventreProgress != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AdventreProgress);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001E27 RID: 7719 RVA: 0x00052688 File Offset: 0x00050888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdventreTask other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.State != 0)
			{
				this.State = other.State;
			}
			if (other.AdventreProgress != 0)
			{
				this.AdventreProgress = other.AdventreProgress;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001E28 RID: 7720 RVA: 0x000526EC File Offset: 0x000508EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001E29 RID: 7721 RVA: 0x000526F8 File Offset: 0x000508F8
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
							this.AdventreProgress = input.ReadInt32();
						}
					}
					else
					{
						this.State = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002342 RID: 9026
		private static readonly MessageParser<AdventreTask> _parser = new MessageParser<AdventreTask>(() => new AdventreTask());

		// Token: 0x04002343 RID: 9027
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002344 RID: 9028
		public const int IdFieldNumber = 1;

		// Token: 0x04002345 RID: 9029
		private int id_;

		// Token: 0x04002346 RID: 9030
		public const int StateFieldNumber = 2;

		// Token: 0x04002347 RID: 9031
		private int state_;

		// Token: 0x04002348 RID: 9032
		public const int AdventreProgressFieldNumber = 3;

		// Token: 0x04002349 RID: 9033
		private int adventreProgress_;
	}
}
