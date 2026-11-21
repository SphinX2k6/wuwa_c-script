using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ADE RID: 2782
	[NetMessage(EMessageId.NavigationFindPathRequest)]
	public sealed class NavigationFindPathRequest : IMessage<NavigationFindPathRequest>, IMessage, IEquatable<NavigationFindPathRequest>, IDeepCloneable<NavigationFindPathRequest>, IBufferMessage
	{
		// Token: 0x0600F247 RID: 62023 RVA: 0x002364DC File Offset: 0x002346DC
		[NullableContext(1)]
		public static NavigationFindPathRequest Create()
		{
			return new NavigationFindPathRequest();
		}

		// Token: 0x17003151 RID: 12625
		// (get) Token: 0x0600F248 RID: 62024 RVA: 0x002364E3 File Offset: 0x002346E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003152 RID: 12626
		// (get) Token: 0x0600F249 RID: 62025 RVA: 0x002364E6 File Offset: 0x002346E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NavigationFindPathRequest.Descriptor;
			}
		}

		// Token: 0x0600F24A RID: 62026 RVA: 0x002364ED File Offset: 0x002346ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NavigationFindPathRequest()
		{
		}

		// Token: 0x0600F24B RID: 62027 RVA: 0x002364F8 File Offset: 0x002346F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NavigationFindPathRequest(NavigationFindPathRequest other) : this()
		{
			this.startPos_ = ((other.startPos_ != null) ? other.startPos_.Clone() : null);
			this.endPos_ = ((other.endPos_ != null) ? other.endPos_.Clone() : null);
			this.mapId_ = other.mapId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F24C RID: 62028 RVA: 0x00236560 File Offset: 0x00234760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NavigationFindPathRequest Clone()
		{
			return new NavigationFindPathRequest(this);
		}

		// Token: 0x17003153 RID: 12627
		// (get) Token: 0x0600F24D RID: 62029 RVA: 0x00236568 File Offset: 0x00234768
		// (set) Token: 0x0600F24E RID: 62030 RVA: 0x00236570 File Offset: 0x00234770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector StartPos
		{
			get
			{
				return this.startPos_;
			}
			set
			{
				this.startPos_ = value;
			}
		}

		// Token: 0x17003154 RID: 12628
		// (get) Token: 0x0600F24F RID: 62031 RVA: 0x00236579 File Offset: 0x00234779
		// (set) Token: 0x0600F250 RID: 62032 RVA: 0x00236581 File Offset: 0x00234781
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector EndPos
		{
			get
			{
				return this.endPos_;
			}
			set
			{
				this.endPos_ = value;
			}
		}

		// Token: 0x17003155 RID: 12629
		// (get) Token: 0x0600F251 RID: 62033 RVA: 0x0023658A File Offset: 0x0023478A
		// (set) Token: 0x0600F252 RID: 62034 RVA: 0x00236592 File Offset: 0x00234792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MapId
		{
			get
			{
				return this.mapId_;
			}
			set
			{
				this.mapId_ = value;
			}
		}

		// Token: 0x0600F253 RID: 62035 RVA: 0x0023659B File Offset: 0x0023479B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NavigationFindPathRequest);
		}

		// Token: 0x0600F254 RID: 62036 RVA: 0x002365AC File Offset: 0x002347AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NavigationFindPathRequest other)
		{
			return other != null && (other == this || (object.Equals(this.StartPos, other.StartPos) && object.Equals(this.EndPos, other.EndPos) && this.MapId == other.MapId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F255 RID: 62037 RVA: 0x00236610 File Offset: 0x00234810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.startPos_ != null)
			{
				num ^= this.StartPos.GetHashCode();
			}
			if (this.endPos_ != null)
			{
				num ^= this.EndPos.GetHashCode();
			}
			if (this.MapId != 0)
			{
				num ^= this.MapId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F256 RID: 62038 RVA: 0x0023667B File Offset: 0x0023487B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F257 RID: 62039 RVA: 0x00236688 File Offset: 0x00234888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F258 RID: 62040 RVA: 0x00236694 File Offset: 0x00234894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.endPos_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.EndPos);
			}
			if (this.MapId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.MapId);
			}
			if (this.startPos_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.StartPos);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F259 RID: 62041 RVA: 0x0023670C File Offset: 0x0023490C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.startPos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StartPos);
			}
			if (this.endPos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EndPos);
			}
			if (this.MapId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MapId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F25A RID: 62042 RVA: 0x0023677C File Offset: 0x0023497C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NavigationFindPathRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.startPos_ != null)
			{
				if (this.startPos_ == null)
				{
					this.StartPos = new Vector();
				}
				this.StartPos.MergeFrom(other.StartPos);
			}
			if (other.endPos_ != null)
			{
				if (this.endPos_ == null)
				{
					this.EndPos = new Vector();
				}
				this.EndPos.MergeFrom(other.EndPos);
			}
			if (other.MapId != 0)
			{
				this.MapId = other.MapId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F25B RID: 62043 RVA: 0x00236810 File Offset: 0x00234A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F25C RID: 62044 RVA: 0x0023681C File Offset: 0x00234A1C
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
				if (num != 42U)
				{
					if (num != 88U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.startPos_ == null)
							{
								this.StartPos = new Vector();
							}
							input.ReadMessage(this.StartPos);
						}
					}
					else
					{
						this.MapId = input.ReadInt32();
					}
				}
				else
				{
					if (this.endPos_ == null)
					{
						this.EndPos = new Vector();
					}
					input.ReadMessage(this.EndPos);
				}
			}
		}

		// Token: 0x04006223 RID: 25123
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006224 RID: 25124
		public const int StartPosFieldNumber = 14;

		// Token: 0x04006225 RID: 25125
		private Vector startPos_;

		// Token: 0x04006226 RID: 25126
		public const int EndPosFieldNumber = 5;

		// Token: 0x04006227 RID: 25127
		private Vector endPos_;

		// Token: 0x04006228 RID: 25128
		public const int MapIdFieldNumber = 11;

		// Token: 0x04006229 RID: 25129
		private int mapId_;
	}
}
