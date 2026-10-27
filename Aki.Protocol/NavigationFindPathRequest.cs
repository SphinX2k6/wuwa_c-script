using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AEF RID: 2799
	[NetMessage(EMessageId.NavigationFindPathRequest)]
	public sealed class NavigationFindPathRequest : IMessage<NavigationFindPathRequest>, IMessage, IEquatable<NavigationFindPathRequest>, IDeepCloneable<NavigationFindPathRequest>, IBufferMessage
	{
		// Token: 0x0600F361 RID: 62305 RVA: 0x002386E4 File Offset: 0x002368E4
		[NullableContext(1)]
		public static NavigationFindPathRequest Create()
		{
			return new NavigationFindPathRequest();
		}

		// Token: 0x1700318F RID: 12687
		// (get) Token: 0x0600F362 RID: 62306 RVA: 0x002386EB File Offset: 0x002368EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003190 RID: 12688
		// (get) Token: 0x0600F363 RID: 62307 RVA: 0x002386EE File Offset: 0x002368EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NavigationFindPathRequest.Descriptor;
			}
		}

		// Token: 0x0600F364 RID: 62308 RVA: 0x002386F5 File Offset: 0x002368F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NavigationFindPathRequest()
		{
		}

		// Token: 0x0600F365 RID: 62309 RVA: 0x00238700 File Offset: 0x00236900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NavigationFindPathRequest(NavigationFindPathRequest other) : this()
		{
			this.startPos_ = ((other.startPos_ != null) ? other.startPos_.Clone() : null);
			this.endPos_ = ((other.endPos_ != null) ? other.endPos_.Clone() : null);
			this.mapId_ = other.mapId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F366 RID: 62310 RVA: 0x00238768 File Offset: 0x00236968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NavigationFindPathRequest Clone()
		{
			return new NavigationFindPathRequest(this);
		}

		// Token: 0x17003191 RID: 12689
		// (get) Token: 0x0600F367 RID: 62311 RVA: 0x00238770 File Offset: 0x00236970
		// (set) Token: 0x0600F368 RID: 62312 RVA: 0x00238778 File Offset: 0x00236978
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

		// Token: 0x17003192 RID: 12690
		// (get) Token: 0x0600F369 RID: 62313 RVA: 0x00238781 File Offset: 0x00236981
		// (set) Token: 0x0600F36A RID: 62314 RVA: 0x00238789 File Offset: 0x00236989
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

		// Token: 0x17003193 RID: 12691
		// (get) Token: 0x0600F36B RID: 62315 RVA: 0x00238792 File Offset: 0x00236992
		// (set) Token: 0x0600F36C RID: 62316 RVA: 0x0023879A File Offset: 0x0023699A
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

		// Token: 0x0600F36D RID: 62317 RVA: 0x002387A3 File Offset: 0x002369A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NavigationFindPathRequest);
		}

		// Token: 0x0600F36E RID: 62318 RVA: 0x002387B4 File Offset: 0x002369B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NavigationFindPathRequest other)
		{
			return other != null && (other == this || (object.Equals(this.StartPos, other.StartPos) && object.Equals(this.EndPos, other.EndPos) && this.MapId == other.MapId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F36F RID: 62319 RVA: 0x00238818 File Offset: 0x00236A18
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

		// Token: 0x0600F370 RID: 62320 RVA: 0x00238883 File Offset: 0x00236A83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F371 RID: 62321 RVA: 0x00238890 File Offset: 0x00236A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F372 RID: 62322 RVA: 0x0023889C File Offset: 0x00236A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.startPos_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.StartPos);
			}
			if (this.MapId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.MapId);
			}
			if (this.endPos_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.EndPos);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F373 RID: 62323 RVA: 0x00238914 File Offset: 0x00236B14
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

		// Token: 0x0600F374 RID: 62324 RVA: 0x00238984 File Offset: 0x00236B84
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

		// Token: 0x0600F375 RID: 62325 RVA: 0x00238A18 File Offset: 0x00236C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F376 RID: 62326 RVA: 0x00238A24 File Offset: 0x00236C24
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
				if (num != 10U)
				{
					if (num != 64U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
					else
					{
						this.MapId = input.ReadInt32();
					}
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
		}

		// Token: 0x0400621A RID: 25114
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400621B RID: 25115
		public const int StartPosFieldNumber = 1;

		// Token: 0x0400621C RID: 25116
		private Vector startPos_;

		// Token: 0x0400621D RID: 25117
		public const int EndPosFieldNumber = 15;

		// Token: 0x0400621E RID: 25118
		private Vector endPos_;

		// Token: 0x0400621F RID: 25119
		public const int MapIdFieldNumber = 8;

		// Token: 0x04006220 RID: 25120
		private int mapId_;
	}
}
