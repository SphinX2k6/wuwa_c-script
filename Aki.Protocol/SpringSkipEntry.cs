using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001286 RID: 4742
	public sealed class SpringSkipEntry : IMessage<SpringSkipEntry>, IMessage, IEquatable<SpringSkipEntry>, IDeepCloneable<SpringSkipEntry>, IBufferMessage
	{
		// Token: 0x06019405 RID: 103429 RVA: 0x003AC2D9 File Offset: 0x003AA4D9
		[NullableContext(1)]
		public static SpringSkipEntry Create()
		{
			return new SpringSkipEntry();
		}

		// Token: 0x1700552C RID: 21804
		// (get) Token: 0x06019406 RID: 103430 RVA: 0x003AC2E0 File Offset: 0x003AA4E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpringSkipEntry> Parser
		{
			get
			{
				return SpringSkipEntry._parser;
			}
		}

		// Token: 0x1700552D RID: 21805
		// (get) Token: 0x06019407 RID: 103431 RVA: 0x003AC2E7 File Offset: 0x003AA4E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700552E RID: 21806
		// (get) Token: 0x06019408 RID: 103432 RVA: 0x003AC2EA File Offset: 0x003AA4EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringSkipEntry.Descriptor;
			}
		}

		// Token: 0x06019409 RID: 103433 RVA: 0x003AC2F1 File Offset: 0x003AA4F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSkipEntry()
		{
		}

		// Token: 0x0601940A RID: 103434 RVA: 0x003AC2F9 File Offset: 0x003AA4F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSkipEntry(SpringSkipEntry other) : this()
		{
			this.id_ = other.id_;
			this.unLock_ = other.unLock_;
			this.finish_ = other.finish_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601940B RID: 103435 RVA: 0x003AC336 File Offset: 0x003AA536
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSkipEntry Clone()
		{
			return new SpringSkipEntry(this);
		}

		// Token: 0x1700552F RID: 21807
		// (get) Token: 0x0601940C RID: 103436 RVA: 0x003AC33E File Offset: 0x003AA53E
		// (set) Token: 0x0601940D RID: 103437 RVA: 0x003AC346 File Offset: 0x003AA546
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

		// Token: 0x17005530 RID: 21808
		// (get) Token: 0x0601940E RID: 103438 RVA: 0x003AC34F File Offset: 0x003AA54F
		// (set) Token: 0x0601940F RID: 103439 RVA: 0x003AC357 File Offset: 0x003AA557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool UnLock
		{
			get
			{
				return this.unLock_;
			}
			set
			{
				this.unLock_ = value;
			}
		}

		// Token: 0x17005531 RID: 21809
		// (get) Token: 0x06019410 RID: 103440 RVA: 0x003AC360 File Offset: 0x003AA560
		// (set) Token: 0x06019411 RID: 103441 RVA: 0x003AC368 File Offset: 0x003AA568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Finish
		{
			get
			{
				return this.finish_;
			}
			set
			{
				this.finish_ = value;
			}
		}

		// Token: 0x06019412 RID: 103442 RVA: 0x003AC371 File Offset: 0x003AA571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringSkipEntry);
		}

		// Token: 0x06019413 RID: 103443 RVA: 0x003AC380 File Offset: 0x003AA580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringSkipEntry other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.UnLock == other.UnLock && this.Finish == other.Finish && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019414 RID: 103444 RVA: 0x003AC3DC File Offset: 0x003AA5DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.UnLock)
			{
				num ^= this.UnLock.GetHashCode();
			}
			if (this.Finish)
			{
				num ^= this.Finish.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019415 RID: 103445 RVA: 0x003AC44D File Offset: 0x003AA64D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019416 RID: 103446 RVA: 0x003AC45A File Offset: 0x003AA65A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019417 RID: 103447 RVA: 0x003AC464 File Offset: 0x003AA664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.UnLock)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.UnLock);
			}
			if (this.Finish)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Finish);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019418 RID: 103448 RVA: 0x003AC4D8 File Offset: 0x003AA6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.UnLock)
			{
				num += 2;
			}
			if (this.Finish)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019419 RID: 103449 RVA: 0x003AC530 File Offset: 0x003AA730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringSkipEntry other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.UnLock)
			{
				this.UnLock = other.UnLock;
			}
			if (other.Finish)
			{
				this.Finish = other.Finish;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601941A RID: 103450 RVA: 0x003AC594 File Offset: 0x003AA794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601941B RID: 103451 RVA: 0x003AC5A0 File Offset: 0x003AA7A0
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
							this.Finish = input.ReadBool();
						}
					}
					else
					{
						this.UnLock = input.ReadBool();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009481 RID: 38017
		private static readonly MessageParser<SpringSkipEntry> _parser = new MessageParser<SpringSkipEntry>(() => new SpringSkipEntry());

		// Token: 0x04009482 RID: 38018
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009483 RID: 38019
		public const int IdFieldNumber = 1;

		// Token: 0x04009484 RID: 38020
		private int id_;

		// Token: 0x04009485 RID: 38021
		public const int UnLockFieldNumber = 2;

		// Token: 0x04009486 RID: 38022
		private bool unLock_;

		// Token: 0x04009487 RID: 38023
		public const int FinishFieldNumber = 3;

		// Token: 0x04009488 RID: 38024
		private bool finish_;
	}
}
